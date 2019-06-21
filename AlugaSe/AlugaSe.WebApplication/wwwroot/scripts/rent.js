'use strict';

var rent = (function ($) {

    var init = function () {

        $('.btn-add-item').on('click', addItem);
        $('.btn-save-rent').on('click', saverent);
        $('.item-remove').on('click', removeItem);
        $('.item-product').on('change', setUnitPrice);
        showproductsVendor();

    };

    var showproductsVendor = function () {

        var Vendor = $("#CodigoVendor").val();

        $('.item-product option').removeClass('hide');

        $('.item-product option').each(function () {
            if ($(this).data('Vendor') != Vendor && $(this).val() != "-1")
                $(this).addClass('hide');
        });
    }

    var addItem = function () {
        $('.items').append($('.model').html());
        $('.item-remove').on('click', removeItem);
        $('.item-product').on('change', setUnitPrice);
    }

    var removeItem = function () {
        $(this).closest('.rent-item').remove();
    }

    var setUnitPrice = function () {
        $(this).closest('.rent-item').find('.item-unit-price').html($("option:selected", this).data('price'));
    }

    var getitems = function () {

        var items = [];

        $('.items .rent-item').each(function () {

            items.push({

                'ProductId': $(this).find('.item-product').val(),
                'Quantity': $(this).find('.item-quantity').val(),
                'UnitPrice': $(this).find('.item-unit-price').html().replace(',', '.'),
                'InitialDate': moment($(this).find('.item-initial-date').val()).format("YYYY-MM-DD"),
                'EndDate': moment($(this).find('.item-end-date').val()).format("YYYY-MM-DD")
            })

        });

        return items;
    }

    var validate = function (rent) {

        var valid = true;

        $(".field-validation-valid").html('');
        $(".field-validation-valid").addClass('hide');

        if (rent.CustomerId == null) {
            $("#customer-validation").html("Customer is required!");
            $("#customer-validation").removeClass("hide");
            valid = false;
        }

        if (rent.RentItems == null || rent.RentItems.length == 0) {
            $("#rent-item-validation").html("Rent needs at least one item!!");
            $("#rent-item-validation").removeClass("hide");
            valid = false;
        }

        $('.items .rent-item').each(function () {

            if ($(this).find('.item-product').val() == null || $(this).find('.item-product').val() == "-1") {
                $(this).find(".rent-item-product-validation").html("Select a product");
                $(this).find(".rent-item-product-validation").removeClass("hide");
                valid = false;
            }

            if ((+$(this).find('.item-quantity').val()) == null || (+$(this).find('.item-quantity').val()) == 0) {
                $(this).find(".rent-item-quantity-validation").html("Product quantity can't be zero.");
                $(this).find(".rent-item-quantity-validation").removeClass("hide");
                valid = false;
            }

            var mInitalDate = moment($(this).find('.item-initial-date').val());
            var mEndDate = moment($(this).find('.item-end-date').val());

            if (!mInitalDate.isValid()) {
                $(this).find(".rent-item-initial-date-validation").html("Initial date is required.");
                $(this).find(".rent-item-initial-date-validation").removeClass("hide");
                valid = false;
            }

            if (!mEndDate.isValid()) {
                $(this).find(".rent-item-end-date-validation").html("End date is required.");
                $(this).find(".rent-item-end-date-validation").removeClass("hide");
                valid = false;
            }

            if (mInitalDate.isValid() && mEndDate.isValid()) {

                if (mInitalDate.isAfter(mEndDate) || mEndDate.isBefore(mInitalDate)) {

                    $(this).find(".rent-item-initial-date-validation").html("Initial date must be before than end date.");
                    $(this).find(".rent-item-initial-date-validation").removeClass("hide");

                    $(this).find(".rent-item-end-date-validation").html("End date must be after than initial date.");
                    $(this).find(".rent-item-end-date-validation").removeClass("hide");
                    valid = false;
                }
            }

        });

        return valid;
    }

    var saverent = function () {

        var rent = {
            //"Codigorent": typeof $("#Codigorent").val() === "undefined" ? 0 : $("#Codigorent").val(),
            "CustomerId": $('#CustomerId').val(),
            "RentItems": getitems()
        }

        if (validate(rent) == false)
            return false;

        $.ajax({
            type: 'POST',
            url: "/Rent/Create/",
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            data: JSON.stringify(rent),
            error: function (response) {
                alert(response);
            },
            success: function (response) {
                window.location = "/Rent/Index/";
            }
        });
    }

    return {
        init: init
    };

})(jQuery);

document.addEventListener("DOMContentLoaded", rent.init);
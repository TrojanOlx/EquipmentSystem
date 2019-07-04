var _service = abp.services.app.t_Equipment;

(function () {
    var _$modal = $("#EquipmentCreateModal");
    var _$form = _$modal.find("form");
    _$form.validate();

    _$form.find('button[type="submit"]').click(function (e) {
        e.preventDefault();
        if (!_$form.valid()) {
            return;
        }

        var equipmentEditDto = _$form.serializeFormToObject();
        console.log(equipmentEditDto);
        abp.ui.setBusy(_$modal);
        _service.createOrUpdateEquipmentAsync({ equipmentEditDto }).done(function () {
            _$modal.modal("hide");
            location.reload(true);
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    });
    _$modal.on("shown.bs.modal",
        function () {
            _$modal.find("input:not([type=hidden]):first").focus();
        });
})();
var _service = abp.services.app.t_EquipmentType;

    //equipmentType
(function() {
    var _$modal = $("#EquipmentTypeCreateModal");
    var _$form = _$modal.find("form");
    _$form.validate();

    _$form.find('button[type="submit"]').click(function(e) {
        e.preventDefault();
        if (!_$form.valid()) {
            return;
        }

        var equipmentTypeForEditOutputDto = _$form.serializeFormToObject();
        abp.ui.setBusy(_$modal);
        _service.createOrUpdateEquipmentTypeAsync({ equipmentTypeForEditOutputDto }).done(function() {
            _$modal.modal("hide");
            location.reload(true);
        }).always(function() {
            abp.ui.clearBusy(_$modal);
        });
    });
    _$modal.on("shown.bs.modal",
        function() {
            _$modal.find("input:not([type=hidden]):first").focus();
        });
})();

function editEquipmentType(id) {
    _service.getEquipmentTypeForEditOutputAsync({ id: id }).done(
        function (data) {
            data = data.result;
            $("input[name=TypeName]").val(data.equipmentTypeForEditOutput.typeName);
            $("input[name=Id]").val(data.equipmentTypeForEditOutput.id);
        }
    );
}

function deleteEquipmentType(id,typeName) {
    abp.message.confirm(
        "是否删除" + typeName + "?",
        function() {
            _service.deleteEquipmentTypeAsync({ id: id }).done(
                function () {
                    location.reload(true);
            });
        }
    );
}
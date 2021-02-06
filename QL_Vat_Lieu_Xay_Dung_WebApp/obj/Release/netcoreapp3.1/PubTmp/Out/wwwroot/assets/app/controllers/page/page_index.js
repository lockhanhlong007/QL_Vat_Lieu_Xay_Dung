var PageAjax = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
        registerControls();
    }

    function registerEvents() {
        //Init validation
        $("#frmMaintainance").validate({
            errorClass: "red",
            ignore: [],
            lang: "en",
            rules: {
                txtNameM: { required: true },
                txtAliasM: { required: true }
            }
        });

        $("#txt-search-keyword").keypress(function (e) {
            if (e.which === 13) {
                e.preventDefault();
                loadData();
            }
        });
        $("#btn-search").on("click", function () {
            loadData();
        });

        $("#ddl-show-page").on("change", function () {
            app.configs.pageSize = $(this).val();
            app.configs.pageIndex = 1;
            loadData(true);
        });

        $("#btn-create").on("click", function () {
            resetFormMaintainance();
            $("#modal-add-edit").modal("show");

        });

        $("body").on("click", ".btn-edit", function (e) {
            e.preventDefault();
            var that = $(this).data("id");
            $.ajax({
                type: "GET",
                url: "/Admin/Page/GetById",
                data: { id: that },
                dataType: "json",
                beforeSend: function () {
                    app.startLoading();
                },
                success: function (response) {
                    var data = response;
                    $("#hidId").val(data.Id);
                    $("#txtName").val(data.Name);

                    $("#txtAlias").val(data.Alias);
                    CKEDITOR.instances.txtContent.setData(data.Content);
                    $("#ckStatus").prop("checked", data.Status === 1);

                    $("#modal-add-edit").modal("show");
                    app.stopLoading();

                },
                error: function () {
                    app.notify("Có lỗi xảy ra", "error");
                    app.stopLoading();
                }
            });
        });

        $("#btnSave").on("click", function (e) {
            if ($("#frmMaintainance").valid()) {
                e.preventDefault();
                var id = $("#hidId").val();
                var name = $("#txtName").val();
                var seoAlias = $("#txtAlias").val();
                var content = CKEDITOR.instances.txtContent.getData();
                var status = $("#ckStatus").prop("checked") === true ? 1 : 0;

                $.ajax({
                    type: "POST",
                    url: "/Admin/Page/SaveEntity",
                    data: {
                        Id: id,
                        Name: name,
                        Content: content,
                        Status: status,
                        Alias: seoAlias
                    },
                    dataType: "json",
                    beforeSend: function () {
                        app.startLoading();
                    },
                    success: function () {
                        app.notify("Update page successful", "success");
                        $("#modal-add-edit").modal("hide");
                        resetFormMaintainance();

                        app.stopLoading();
                        loadData(true);
                    },
                    error: function () {
                        app.notify("Have an error in progress", "error");
                        app.stopLoading();
                    }
                });
                return false;
            }
            return false;
        });

        $("body").on("click", ".btn-delete", function (e) {
            e.preventDefault();
            var that = $(this).data("id");
            app.confirm("Are you sure to delete?", function () {
                $.ajax({
                    type: "POST",
                    url: "/Admin/Page/Delete",
                    data: { id: that },
                    dataType: "json",
                    beforeSend: function () {
                        app.startLoading();
                    },
                    success: function () {
                        app.notify("Delete page successful", "success");
                        app.stopLoading();
                        loadData();
                    },
                    error: function () {
                        app.notify("Have an error in progress", "error");
                        app.stopLoading();
                    }
                });
            });
        });
    };

    function resetFormMaintainance() {
        $("#hidId").val(0);
        $("#txtName").val("");
        $("#txtAlias").val("");
        CKEDITOR.instances.txtContent.setData("");
        $("#ckStatus").prop("checked", true);

    }

    function registerControls() {
        var editorConfig = {
            filebrowserImageUploadUrl: "/Admin/Upload/UploadImageForCKEditor?type=Images"
        }
        CKEDITOR.replace("txtContent", editorConfig);
        //Fix: cannot click on element ck in modal
        $.fn.modal.Constructor.prototype.enforceFocus = function () {
            $(document)
                .off("focusin.bs.modal") // guard against infinite focus loop
                .on("focusin.bs.modal", $.proxy(function (e) {
                    if (
                        this.$element[0] !== e.target && !this.$element.has(e.target).length
                        // CKEditor compatibility fix start.
                        && !$(e.target).closest(".cke_dialog, .cke").length
                        // CKEditor compatibility fix end.
                    ) {
                        this.$element.trigger("focus");
                    }
                }, this));
        };
    }

    function loadData(isPageChanged) {
        $.ajax({
            type: "GET",
            url: "/admin/page/GetAllPaging",
            data: {
                keyword: $("#txt-search-keyword").val(),
                page: app.configs.pageIndex,
                pageSize: app.configs.pageSize
            },
            dataType: "json",
            beforeSend: function () {
                app.startLoading();
            },
            success: function (response) {
                var template = $("#table-template").html();
                var render = "";
                if (response.RowCount > 0) {
                    $.each(response.Results, function (i, item) {
                        render += Mustache.render(template, {
                            Name: item.Name,
                            Alias: item.Alias,
                            Id: item.Id,
                            Status: app.getStatus(item.Status)
                        });
                    });
                    $("#lbl-total-records").text(response.RowCount);
                    if (render != undefined) {
                        $("#tbl-content").html(render);

                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);


                }
                else {
                    $("#tbl-content").html("");
                }
                app.stopLoading();
            },
            error: function (status) {
                console.log(status);
            }
        });
    };

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / app.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($("#paginationUL a").length === 0 || changePageSize === true) {
            $("#paginationUL").empty();
            $("#paginationUL").removeData("twbs-pagination");
            $("#paginationUL").unbind("page");
        }
        //Bind Pagination Event
        $("#paginationUL").twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: "Đầu",
            prev: "Trước",
            next: "Tiếp",
            last: "Cuối",
            onPageClick: function (event, p) {
                app.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}
async function editButtonOnClick(e, url) {
    $('[name="id"]').val(e.row.data.id);

    let res = (await (await fetch(url+'/Get?id=' + e.row.data.id)).json());

    let form = $("#genericform").dxForm("instance");
    form.option("formData", res);
    form.itemOption('silbtn', 'visible', true);

    $('#genericmodal').modal('show')
}
let kaydetbtn={
    itemType: "button",
    horizontalAlignment: "Left",
    buttonOptions: {
        text: "Kaydet",
        type: "success",
        useSubmitBehavior: true
    }
};

let buttomButtons = {
    itemType: "group",
    colCount: 2,
    items: [kaydetbtn,
        {
            dataField: "silbtn",
            itemType: "button",
            horizontalAlignment: "Right",
            buttonOptions: {
                text: "Sil",
                type: "danger",
                onClick: function () {
                    deleteForm()
                }
            }
        }
    ]
};
let pages = [
    {
        url: '/Araclar',
        name: 'Araç Yönetimi',
        form: [{
            dataField: "plaka",
            editorOptions: {
                maxLength: 20
            },
            validationRules: [{
                type: "required",
                message: "Lütfen plaka giriniz."
            }]
        },
            {
                itemType: "group",
                colCount: 2,
                items: [{
                    dataField: "markaId",
                    label: {
                        text: "Marka"
                    },
                    editorType: "dxSelectBox",
                    editorOptions: {
                        placeholder: 'Marka Seçiniz',
                        dataSource: {
                            store: {
                                type: "odata",
                                url: "/LookupList/Marka"
                            }
                        },
                        displayExpr: "text",
                        valueExpr: "id",
                    }
                }, {
                    dataField: "model",
                    editorOptions: {
                        maxLength: 100
                    }
                }]
            },
            {
                itemType: "group",
                colCount: 2,
                items: [{
                    dataField: "motor",
                    editorOptions: {
                        maxLength: 50
                    }
                },
                    {
                        dataField: "ticari",
                        label: {
                            text: "Ticari / Binek"
                        },
                        editorType: "dxSelectBox",
                        editorOptions: {
                            items: [{
                                text: "Ticari",
                                id: true
                            },
                                {
                                    text: "Binek",
                                    id: false
                                },
                            ],
                            displayExpr: "text",
                            valueExpr: "id",
                        }
                    },
                ]
            },
            {
                itemType: "group",
                colCount: 2,
                items: [{
                    dataField: "yil",
                    label: {
                        text: "Yıl"
                    },
                    editorOptions: {
                        type: "number"
                    }
                },
                    {
                        dataField: "km",
                        editorOptions: {
                            type: "number"
                        }
                    }
                ]
            },
            {
                itemType: "group",
                colCount: 2,
                items: [{
                    dataField: "yakitId",
                    label: {
                        text: "Yakıt Tipi"
                    },
                    editorType: "dxSelectBox",
                    editorOptions: {
                        dataSource: {
                            store: {
                                type: "odata",
                                url: "/LookupList/Yakıt"
                            }
                        },
                        displayExpr: "text",
                        valueExpr: "id",
                    }
                },
                    {
                        dataField: "otomatik",
                        label: {
                            text: "Vites Tipi"
                        },
                        editorType: "dxSelectBox",
                        editorOptions: {
                            items: [{
                                text: "Manuel",
                                id: false
                            },
                                {
                                    text: "Otomatik",
                                    id: true
                                },
                            ],
                            displayExpr: "text",
                            valueExpr: "id",
                        }
                    },
                ]
            },
            {
                dataField: "ruhsatSahibiAdSoyad",
                label: {
                    text: "Ruhsat Sahibinin Adı Soyadı"
                },
                name: "RuhsatSahibiAdSoyad"
            },
            {
                labelLocation: "bottom",
                dataField: "enSonBakimYetkiliServis",
                label: {
                    text: "En Son Bakim Yetkili Serviste Yapıldı",
                    location: "left",
                    alignment: "left"
                },
                editorType: "dxCheckBox"
            },
            buttomButtons
        ],
        table: [
            {
                type: "buttons",
                buttons: [{
                    hint: "Düzenle",
                    icon: "edit",
                    onClick: (e)=>editButtonOnClick(e,"/Araclar")
                }]
            },
            {
                dataField: "id",
                caption: "No",
            },
            {
                dataField: "plaka",
                caption: "Plaka",
            },
            {
                dataField: "marka",
                caption: "Marka",
            },
            {
                dataField: "model",
                caption: "Model",
            },
            {
                dataField: "ticariBinek",
                caption: "Ticari / Binek",
            },
            {
                dataField: "yil",
                caption: "Yıl",
            },
            {
                dataField: "km",
                caption: "Km",
                visible: false
            },
            {
                dataField: "yakit",
                caption: "Yakıt Tipi",
            },
            {
                dataField: "vites",
                caption: "Vites Tipi",
                visible: false
            },
            {
                caption: "Ruhsat Sahibinin Adı Soyadı",
                dataField: "ruhsatSahibiAdSoyad",
                visible: false
            },
            {
                dataField: "enSonBakimYetkiliServis",
                caption: "En Son Bakım Yetkili Servis",
                dataType: "boolean",
                visible: false
            },
            {
                dataField: "creator",
                visible: false,
                caption: "Kullanıcı",
            },
            {
                dataField: "createDate",
                visible: false,
                caption: "Tarih",
                dataType: "date"
            },
        ]
    },
    {
        url: '/Musteriler',
        name: 'Müşteri Yönetimi',
        form: [
            {
                dataField: "kullanici.adSoyad",
                label: {
                    text: "Ad Soyad"
                },
                editorOptions: {
                    maxLength: 100
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen ad soyad giriniz."
                }]
            },

            {
                itemType: "group",
                colCount: 2,
                items: [
                    {
                        dataField: "kullanici.eposta",
                        label: {
                            text: "Eposta"
                        },
                        editorOptions: {
                            maxLength: 100
                        },
                        validationRules: [{
                            type: "required",
                            message: "Lütfen eposta giriniz."
                        }]
                    },
                    {
                        dataField: "kullanici.telefon",
                        editorOptions: {
                            maxLength: 15,
                            mask: "(000) 000-0000"
                        },
                        validationRules: [{
                            type: "required",
                            message: "Lütfen telefon giriniz."
                        }]
                    },
                ]
            },

            {
                dataField: "kullanici.parola",
                label: {
                    text: "Parola"
                },
                editorOptions: {
                    maxLength: 50,
                    mode: "password"
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen eposta giriniz."
                }]
            },
            {
                itemType: "group",
                colCount: 2,
                items: [{
                    dataField: "Il",
                    label: {
                        text: "Il"
                    },
                    editorType: "dxSelectBox",
                    editorOptions: {
                        placeholder: 'Il Seçiniz',
                        dataSource: {
                            store: {
                                type: "odata",
                                url: "/LookupList/Il"
                            }
                        },
                        displayExpr: "text",
                        valueExpr: "id",
                        onValueChanged: (e) => {
                            $("#genericform").dxForm("instance").getEditor("kullanici.ilceId").option('dataSource', {
                                store: {
                                    type: "odata",
                                    url: '/LookupList/Ilce?parentId=' + e.value
                                }
                            });
                        },
                    }
                }, {
                    dataField: "kullanici.ilceId",
                    label: {
                        text: "İlçe"
                    },
                    editorType: "dxSelectBox",
                    editorOptions: {
                        placeholder: 'Ilçe Seçiniz',
                        displayExpr: "text",
                        valueExpr: "id",
                    }
                }]
            },
            {
                dataField: "kullanici.adres",
                label: {
                    text: "Adres"
                },
                editorType: "dxTextArea",
                editorOptions: {
                    placeholder: 'Adres giriniz',
                }
            },
            {
                itemType: 'group',
                colCount: 2,
                items: [
                    {
                        dataField: "sirketAd",
                        label: {
                            text: "Şirket Ad"
                        }
                    },
                    {
                        dataField: "kullanici.unvan",
                        label: {
                            text: "Meslek"
                        }
                    }
                ]
            },
            {
                itemType: "group",
                colCount: 2,
                items: [{
                    dataField: "sirketTelefon",
                    label: {
                        text: "Şirket Telefon",
                    },
                    editorOptions: {
                        maxLength: 15,
                        mask: "(000) 000-0000"
                    }
                },
                    {
                        dataField: "evTelefon",
                        label: {
                            text: "Ev Telefon",
                        },
                        editorOptions: {
                            maxLength: 15,
                            mask: "(000) 000-0000"
                        }
                    },
                ]
            },
            {
                itemType: "group",
                colCount: 2,
                items: [
                    {
                        dataField: "tc",
                        label: {
                            text: "TC Kimlik No"
                        },
                        editorOptions: {
                            maxLength: 11,
                            mask: "00000000000"
                        }
                    },
                    {
                        dataField: "cinsiyetErkek",
                        label: {
                            text: "Cinsiyet"
                        },
                        editorType: "dxSelectBox",
                        editorOptions: {
                            items: [{
                                text: "Erkek",
                                id: true
                            },
                                {
                                    text: "Kadın",
                                    id: false
                                },
                            ],
                            displayExpr: "text",
                            valueExpr: "id",
                        }
                    },
                ]
            },
            {
                labelLocation: "bottom",
                dataField: "sirketAraci",
                label: {
                    text: "Şirket Aracı",
                    location: "left",
                    alignment: "left"
                },
                editorType: "dxCheckBox",
                editorOptions: {
                    onValueChanged: (e) => {
                        $("#genericform").dxForm("instance").itemOption('SirketAdres', 'visible', e.value);
                    }
                }
            },
            {
                visible: false,
                dataField: "sirketAdres",
                label: {
                    text: "Şirket Adresi"
                },
                editorType: "dxTextArea",
                editorOptions: {
                    placeholder: 'Şirket adresi giriniz',
                }
            },
            buttomButtons
        ],
        table: [
            {
                type: "buttons",
                buttons: [{
                    hint: "Düzenle",
                    icon: "edit",
                    onClick: (e)=>editButtonOnClick(e,"/Musteriler")
                }]
            },
            {
                dataField: "id",
                caption: "No",
            },
            {
                dataField: "adSoyad",
                caption: "Ad Soyad",
            },
            {
                dataField: "eposta",
                caption: "Eposta",
            },
            {
                dataField: "telefon",
                caption: "Telefon",
            },
            {
                dataField: "il",
                caption: "Il",
            },
            {
                dataField: "ilce",
                caption: "Ilce",
            },
            {
                dataField: "adres",
                caption: "Adres",
                visible: false
            },
            {
                dataField: "tc",
                caption: "TC Kimlik No",
                visible: false
            },
            {
                dataField: "sirket",
                caption: "Şirket Ad",
            },
            {
                dataField: "unvan",
                caption: "Meslek",
                visible: false
            },
            {
                caption: "Şirket Telefon",
                dataField: "sirketTelefon",
                visible: false
            },
            {
                caption: "Ev Telefon",
                dataField: "evTelefon",
                visible: false
            },
            {
                dataField: "sirketArabasi",
                caption: "Şirket Aracı",
                dataType: "boolean",
                visible: false
            },
            {
                dataField: "sirketAdres",
                visible: false,
                caption: "Şirket Adres",
            },
        ]
    },
    {
        url: '/BakimTalebi',
        name: 'Bakım Talebi Yönetimi',
        form: [
            {
                dataField: "aracId",
                editorType:"dxSelectBox",
                editorOptions:{
                    placeholder: 'Araç Seçiniz',
                    dataSource: {
                        store: {
                            type: "odata",
                            url: "/Araclar/Select"
                        }
                    },
                    displayExpr: "text",
                    valueExpr: "id",
                },
                label: {
                    text: "Araç"
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen araç seçiniz."
                }]
            },
            {
                dataField: "bakimTarihi",
                label: {
                    text: "Bakım Tarihi"
                },
                editorType: "dxDateBox",
                editorOptions: {
                    type: 'date',
                    displayFormat: 'dd.MM.yyyy',
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen bakım tarihi giriniz."
                }]
            },
            {
                dataField: "aciklama",
                label: {
                    text: "Açıklama"
                },
                editorType: "dxTextArea",
                editorOptions: {
                    placeholder: 'Açıklama giriniz',
                    maxLength: 500
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen açıklama giriniz."
                }]
            },
            buttomButtons
        ],
        table: [
            {
                type: "buttons",
                buttons: [{
                    hint: "Düzenle",
                    icon: "edit",
                    onClick: (e)=>editButtonOnClick(e,"/BakimTalebi")
                }]
            },
            {
                dataField: "id",
                caption: "No",
            },
            {
                dataField: "durum",
                caption: "Durum",
            },
            {
                dataField: "plaka",
                caption: "Plaka",
            },
            {
                dataField: "tarih",
                caption: "Tarih",
                dataType: "date"
                
            },
            {
                dataField: "adSoyad",
                caption: "Ad Soyad",
            },
            {
                dataField: "telefon",
                caption: "Telefon",
            },
            {
                dataField: "marka",
                caption: "Marka",
            },
            {
                dataField: "model",
                caption: "Model"
            },
            {
                dataField: "enSonBakimYetkiliServis",
                caption: "En Son Bakım Yetkili Servis",
            },
        ]
    },
    {
        url: '/YetkiliServis',
        name: 'Yetkili Servis Yönetimi',
        form: [
            {
              dataField:'arac.plaka',
              label:{
                  text:"Araç"
              },
                editorOptions:{
                    readOnly:true
                }
            },
            {
                dataField: "bakimTarihi",
                label: {
                    text: "Bakım Tarihi"
                },
                editorType: "dxDateBox",
                editorOptions: {
                    type: 'date',
                    displayFormat: 'dd.MM.yyyy',
                    readOnly:true
                },
            },
            {
                dataField: "aciklama",
                label: {
                    text: "Açıklama"
                },
                editorType: "dxTextArea",
                editorOptions: {
                    readOnly: true,
                },
            },
            {
                dataField: "durumId",
                editorType: "dxSelectBox",
                editorOptions:{
                    placeholder: 'Durum Seçiniz',
                    dataSource: {
                        store: {
                            type: "odata",
                            url: "/LookupList/Bakim"
                        }
                    },
                    displayExpr: "text",
                    valueExpr: "id",
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen durum seçiniz."
                }]
            },

            {
                dataField: "yetkiliServisAciklama",
                label: {
                    text: "Yetkili Servis Açıklama"
                },
                editorType: "dxTextArea",
                editorOptions: {
                    placeholder: 'Açıklama giriniz',
                    maxLength: 500
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen açıklama giriniz."
                }]
            },
            kaydetbtn
        ],
        table: [
            {
                type: "buttons",
                buttons: [{
                    hint: "Düzenle",
                    icon: "edit",
                    onClick: (e)=>editButtonOnClick(e,"/YetkiliServis")
                }]
            },
            {
                dataField: "id",
                caption: "No",
            },
            {
                dataField: "durum",
                caption: "Durum",
            },
            {
                dataField: "plaka",
                caption: "Plaka",
            },
            {
                dataField: "tarih",
                caption: "Tarih",
                dataType: "date"

            },
            {
                dataField: "adSoyad",
                caption: "Ad Soyad",
            },
            {
                dataField: "telefon",
                caption: "Telefon",
            },
            {
                dataField: "marka",
                caption: "Marka",
            },
            {
                dataField: "model",
                caption: "Model"
            },
            {
                dataField: "enSonBakimYetkiliServis",
                caption: "En Son Bakım Yetkili Servis",
            },
        ]
    }
];
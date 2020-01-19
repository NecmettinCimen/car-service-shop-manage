async function editButtonOnClick(e, url, callback) {
    $('[name="id"]').val(e.row.data.id);

    let res = (await (await fetch(url+'/Get?id=' + e.row.data.id)).json());
    if(callback)
        callback(res)

    let form = $("#genericform").dxForm("instance");
    form.option("formData", res);
    form.itemOption('silbtn', 'visible', true);

    $('#genericmodal').modal('show')
}
let buttonIndicator;
let kaydetbtn={
    itemType: "button",
    horizontalAlignment: "Left",
    buttonOptions: {
        text: "Kaydet",
        type: "success",
        useSubmitBehavior: true,
        template: function(data, container) {
            $("<div class='button-indicator' style='height: 32px;width: 32px;display: inline-block;vertical-align: middle;margin-right: 5px;'></div><span class='dx-button-text'>" + data.text + "</span>").appendTo(container);
            buttonIndicator = container.find(".button-indicator").dxLoadIndicator({
                visible: false
            }).dxLoadIndicator("instance");
        },
        onClick: function(data) {
            buttonIndicator.option("visible", true);
        }
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
                        searchEnabled: true,
                        displayExpr: "text",
                        valueExpr: "id",
                        onInitialized :async function (e){
                            var items = await (await fetch('/LookupList/Marka')).json()
                            e.component.option('items',items)
                        }
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
                            searchEnabled: true,
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
                        searchEnabled: true,
                        onInitialized :async function (e){
                            var items = await (await fetch('/LookupList/Yakit')).json()
                            e.component.option('items',items)
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
                            searchEnabled: true,
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
                        searchEnabled: true,
                        placeholder: 'Il Seçiniz',
                        onInitialized :async function (e){
                            var items = await (await fetch('/LookupList/Il')).json()
                            e.component.option('items',items)
                        },
                        displayExpr: "text",
                        valueExpr: "id",
                        onValueChanged:async (e) => {
                            var items = await (await fetch('/LookupList/Ilce?parentId=' + e.value)).json()
                            $("#genericform").dxForm("instance").getEditor("kullanici.ilceId").option('items',items)
                        },
                    }
                }, {
                    dataField: "kullanici.ilceId",
                    label: {
                        text: "İlçe"
                    },
                    editorType: "dxSelectBox",
                    editorOptions: {
                        searchEnabled: true,
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
                            searchEnabled: true,
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
                        $("#genericform").dxForm("instance").itemOption('sirketAdres', 'visible', e.value);
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
                    onClick: (e)=>editButtonOnClick(e,"/Musteriler",(res)=>{
                        fetch('/lookuplist/ililce?ilceid='+res.kullanici.ilceId)
                            .then(res=>res.json())
                            .then(res=>{
                                $("#genericform").dxForm("instance").getEditor("Il").option('value', res.ilid);
                                $("#genericform").dxForm("instance").getEditor("kullanici.ilceId").option('items',res.items)
                            })
                    })
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
                dataField: "meslek",
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
                    onInitialized :async function (e){
                        var items = await (await fetch("/Araclar/Select")).json()
                        e.component.option('items',items)
                    },
                    searchEnabled: true,
                    placeholder: 'Araç Seçiniz',
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
        onInit:function(){
          $('html body div.content.ht-100v.pd-0 div.content-body div.container.pd-x-0 div.d-sm-flex.align-items-center.justify-content-between.mg-b-20.mg-lg-b-25.mg-xl-b-30 div.d-none.d-md-block button.btn.btn-sm.pd-x-15.btn-primary.btn-uppercase.mg-l-5').remove()  
        },
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
                    searchEnabled: true,
                    placeholder: 'Durum Seçiniz',
                    onInitialized :async function (e){
                        var items = await (await fetch("/LookupList/Bakim")).json()
                        e.component.option('items',items)
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
    },
    {
        url: '/Kullanicilar',
        name: 'Kullanıcı Yönetimi',
        form: [
            {
                dataField: "adSoyad",
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
                        dataField: "eposta",
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
                        dataField: "telefon",
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
                itemType: "group",
                colCount: 2,
                items: [
                    {
                        dataField: "parola",
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
                    }, {
                        dataField: "rolId",
                        label: {
                            text: "Rol"
                        },
                        editorType: "dxSelectBox",
                        editorOptions: {
                            searchEnabled: true,
                            placeholder: 'Rol Seçiniz',
                            onInitialized :async function (e){
                                var items = await (await fetch("/Yetkiler/Select")).json()
                                e.component.option('items',items)
                            },
                            displayExpr: "text",
                            valueExpr: "id",
                        },
                        validationRules: [{
                            type: "required",
                            message: "Lütfen eposta giriniz."
                        }]
                    }        
                ]},
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
                        searchEnabled: true,
                        placeholder: 'Il Seçiniz',
                        onInitialized :async function (e){
                            var items = await (await fetch("/LookupList/Il")).json()
                            e.component.option('items',items)
                        },
                        displayExpr: "text",
                        valueExpr: "id",
                        onValueChanged:async (e) => {

                                var items = await (await fetch('/LookupList/Ilce?parentId=' + e.value)).json()
                                $("#genericform").dxForm("instance").getEditor("ilceId").option('items',items)
                        },
                    }
                }, {
                    dataField: "ilceId",
                    label: {
                        text: "İlçe"
                    },
                    editorType: "dxSelectBox",
                    editorOptions: {
                        searchEnabled: true,
                        placeholder: 'Ilçe Seçiniz',
                        displayExpr: "text",
                        valueExpr: "id",
                    }
                }]
            },
            {
                dataField: "adres",
                label: {
                    text: "Adres"
                },
                editorType: "dxTextArea",
                editorOptions: {
                    placeholder: 'Adres giriniz',
                }
            },
            {
                dataField: "unvan",
                label: {
                    text: "Meslek"
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
                    onClick: (e)=>editButtonOnClick(e,"/Kullanicilar")
                }]
            },
            {
                dataField: "id",
                caption: "No",
            },
            {
                dataField: "rol",
                caption: "Rol",
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
                dataField: "adres",
                caption: "Adres",
                visible: false
            },
            {
                dataField: "meslek  ",
                caption: "Meslek",
            },
        ]
    },
    {
        url: '/Yetkiler',
        name: 'Yetki Tanımlamaları Yönetimi',
        form:[
            {
                dataField: "isim",
                label: {
                    text: "İsim"
                },
                editorOptions: {
                    maxLength: 100
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen isim giriniz."
                }]
            },
            {
                dataField: "menuler",
                label: {
                    text: "Menuler"
                },
                editorType: "dxList",
                editorOptions: {
                    onInitialized:async (e)=>{
                        var items =await (await  fetch('/Yetkiler/Menuler')).json();
                        e.component.option('items',items.data)
                    },
                    itemTemplate: function(data, index) {
                        var result = $("<div>").text(data.text)
                        return result;
                    },
                    onSelectionChanged:function(e) {
                        var selectedItems = e.component.option("selectedItems");
                        $('#menuler').remove()
                        $('#genericform').append('<div id="menuler"><input hidden name="menuler" value="'+selectedItems.map(m=>m.id).join(",")+'"></div>')
                    },
                    showSelectionControls: true,
                    selectionMode: "multiple",
                },
                validationRules: [{
                    type: "required",
                    message: "Lütfen menu seciniz giriniz."
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
                    onClick: (e)=>editButtonOnClick(e,"/Yetkiler", function (res){
                        let component = $("#genericform").dxForm("instance").getEditor("menuler");
                        component.unselectAll()
                        res.menuList.map(item=>component.selectItem(item.id-1))
                    })
                }]
            },
            {
                dataField: "id",
                caption: "No",
            },
            {
                dataField: "isim",
                caption: "Rol",
            },
        ]
    }
];
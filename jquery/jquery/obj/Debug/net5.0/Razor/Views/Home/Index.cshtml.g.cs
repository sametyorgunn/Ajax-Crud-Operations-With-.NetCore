#pragma checksum "C:\Users\asame\source\repos\jquery\jquery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe5f4df16fc9204826b28f4c795ca29636c7053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\asame\source\repos\jquery\jquery\Views\_ViewImports.cshtml"
using jquery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asame\source\repos\jquery\jquery\Views\_ViewImports.cshtml"
using jquery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe5f4df16fc9204826b28f4c795ca29636c7053", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acef94a579a51f050137b982e12d9c1535884765", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("personelform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\asame\source\repos\jquery\jquery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe5f4df16fc9204826b28f4c795ca29636c70534225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe5f4df16fc9204826b28f4c795ca29636c70535280", async() => {
                WriteLiteral(@"
  <div class=""form-group"">
    <label for=""formGroupExampleInput"">isim</label>
    <input type=""text"" class=""form-control"" name=""kisi_isim"" id=""formGroupExampleInput"" placeholder=""isim"">
  </div>
  <div class=""form-group"">
    <label for=""formGroupExampleInput2""> soyisim</label>
    <input type=""text"" class=""form-control"" name=""kisi_soyad"" id=""formGroupExampleInput2"" placeholder="" soyisim"">
  </div>
   <div class=""form-group"">
    <label for=""formGroupExampleInput2""> ya??</label>
    <input type=""text"" class=""form-control"" name=""kisi_yas"" id=""formGroupExampleInput2"" placeholder=""ya??"">
  </div>
  <br />
    <div class=""form-group"">
    <label for=""formGroupExampleInput2""> silinecek kisi id</label>
    <input type=""text"" class=""form-control"" name=""kisi_isim"" id=""silinecekkisi"" placeholder=""isim"">
  </div>
  <br />
     <div class=""form-group"">
    <label for=""formGroupExampleInput2""> guncellenecek kisi id</label>
    <input type=""text"" class=""form-control""");
                BeginWriteAttribute("name", " name=\"", 1107, "\"", 1114, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""guncellenecekid"" placeholder=""id"">
  </div>
  <br />
    <div class=""form-group"">
    <label for=""formGroupExampleInput2""> yeni ad</label>
    <input type=""text"" class=""form-control"" name=""kisi_name"" id=""yeniad"" placeholder=""yas"">
  </div>
  <br />
  <div class=""form-group"">
    <label for=""formGroupExampleInput2""> yeni soyad</label>
    <input type=""text"" class=""form-control"" name=""kisi_soyad"" id=""yenisoyad"" placeholder=""soyad"">
  </div>
  <br />
  <div class=""form-group"">
    <label for=""formGroupExampleInput2""> yeni ya??</label>
    <input type=""text"" class=""form-control"" name=""kisi_yas"" id=""yeniyas"" placeholder=""ya??"">
  </div>
  <br />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<button id=""btngonder"" type=""button"">g??nder</button>
<br />
<button onclick=""personelGetir()"" type=""button"">Personel getir</button>
<br />
<button id=""btndeletekisi"" type=""button"">Personel sil</button>
<br />
<button id=""btnpersonelguncelle"" type=""button"">Personel g??ncelle</button>
<br />



<div id=""personelbilgilistele"">


</div>




<script>
    $(""#btngonder"").click(function() {
        var personelbilgi = $(""#personelform"").serialize()
        $.post(""Home/PersonelEkle"", personelbilgi)
            .then(function(data) {
                console.log(data.message)
            })
            .catch, (function(err) {
                console.log(err.message)
            })
    })

</script>
<script>


    function personelGetir() {
        $.post(""/Home/PersonelGetir/"")
            .then(function(model) {
                var personelbilgilisteleContent = """"
                model.map(function(value, index) {
                    personelbilgilisteleContent += `
        ");
            WriteLiteral(@"                    <h1>${value.kisi_id}-${value.kisi_isim} - ${value.kisi_soyad} - ${value.kisi_yas}</h1>
                    `
                })

                $(""#personelbilgilistele"").append(personelbilgilisteleContent)

            })
            .catch(function(err) {
                console.log(err)
            })
    }

</script>

<script>
    $(""#btndeletekisi"").click(x => {
            let id = $(""#silinecekkisi"").val(); 
            $.ajax({
                url: ""/Home/Personelsil/""+id,
                type:""post"",
                dataType:""json"",
                success:function(func){
                    alert(""silme ba??ar??l??"");
                }
            });
        });

</script>

<script>
$(""#btnpersonelguncelle"").click(function(){
     var kisi = {
        kisi_id:$(""#guncellenecekid"").val(),
        kisi_isim:$(""#yeniad"").val(),
        kisi_soyad:$(""#yenisoyad"").val(),
        kisi_yas:$(""#yeniyas"").val()
    };
    $.post(""/Home/PersonelGuncelle""");
            WriteLiteral(", kisi)\r\n        .then(function(model) {\r\n            alert(\"basar??l??\")\r\n        });\r\n})\r\n   \r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

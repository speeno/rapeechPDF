﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clawSoft.clawPDF.Core {
    using System;
    
    
    /// <summary>
    ///   지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    /// </summary>
    // 이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    // 클래스에서 자동으로 생성되었습니다.
    // 멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    // 다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CoreResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreResources() {
        }
        
        /// <summary>
        ///   이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("clawSoft.clawPDF.Core.CoreResources", typeof(CoreResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대해 현재 스레드의 CurrentUICulture 속성을
        ///   재정의합니다.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        internal static byte[] eciRGB_v2 {
            get {
                object obj = ResourceManager.GetObject("eciRGB_v2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        internal static byte[] ISOcoated_v2_300_eci {
            get {
                object obj = ResourceManager.GetObject("ISOcoated_v2_300_eci", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        internal static byte[] ISOcoated_v2_grey1c_bas {
            get {
                object obj = ResourceManager.GetObject("ISOcoated_v2_grey1c_bas", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   %!
        ///% This is a sample prefix file for creating a PDF/A document.
        ///% Users should modify entries marked with &quot;Customize&quot;.
        ///% This assumes an ICC profile resides in the file (srgb.icc),
        ///% in the current directory unless the user modifies the corresponding line below.
        ///
        ///% Define entries in the document Info dictionary :
        ///[ /Title (Title)       % Customise
        ///  /DOCINFO pdfmark
        ///
        ///% Define an ICC profile :
        ////ICCProfile [ICC_PROFILE]
        ///def
        ///
        ///[/_objdef {icc_PDFA} /type /stream /OBJ pdfmark
        ///
        ///%% This code attemp[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        internal static string PdfaDefinition {
            get {
                return ResourceManager.GetString("PdfaDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   %!
        ///% This is a sample prefix file for creating a PDF/X-3 document.
        ///% Users should modify entries marked with &quot;Customize&quot;.
        ///% This assumes an ICC profile resides in the file (ISO Coated sb.icc)
        ///% in the current directory unless the user modifies the corresponding line below.
        ///
        ///% First up, attempt to ensure the user has set ColorConversionStrategy correctly.
        ///% PDF/X-3 only permits Gray or CMYK in the output.
        ///%
        ///systemdict /ColorConversionStrategy known {
        ///  systemdict /ColorConversionStrategy get cvn du[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        internal static string PdfxDefinition {
            get {
                return ResourceManager.GetString("PdfxDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   %!PS
        ////stampstring ([STAMPSTRING]) def
        ////fontname /[FONTNAME] def
        ////fontsize [FONTSIZE] def
        ////fontcolor {[FONTCOLOR]} def
        ////ISOLatin1Encoding [
        ///    /.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef
        ///    /.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef
        ///    /.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef
        ///    /.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef/.notdef
        ///    /space/exclam/quotedbl/numbersign/dollar/percent/ampersand/quoteright
        ///    /parenle[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        internal static string PostScriptStamp {
            get {
                return ResourceManager.GetString("PostScriptStamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.Byte[] 형식의 지역화된 리소스를 찾습니다.
        /// </summary>
        internal static byte[] WebCoatedFOGRA28 {
            get {
                object obj = ResourceManager.GetObject("WebCoatedFOGRA28", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}

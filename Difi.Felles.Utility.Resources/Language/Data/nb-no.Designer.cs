﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Difi.Felles.Utility.Resources.Language.Data {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class nb_no {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal nb_no() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Difi.Felles.Utility.Resources.Language.Data.nb-no", typeof(nb_no).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to gikk ut {0:expirationDateString}..
        /// </summary>
        internal static string CertificateExpiredResult {
            get {
                return ResourceManager.GetString("CertificateExpiredResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to har følgende feil i sertifikatkjeden: {0:prettyChainErrorStatuses}.
        /// </summary>
        internal static string CertificateInvalidChainResult {
            get {
                return ResourceManager.GetString("CertificateInvalidChainResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sertifikat var null! Sjekk at sertifikatet blir lastet korrekt..
        /// </summary>
        internal static string CertificateIsNull {
            get {
                return ResourceManager.GetString("CertificateIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to aktiveres ikke før {0:effectiveDateString}.
        /// </summary>
        internal static string CertificateNotActivatedResult {
            get {
                return ResourceManager.GetString("CertificateNotActivatedResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sertifikatet er ikke utstedt til organisasjonsnummer &apos;{0:certificateOrganizationNumber}&apos;. Dette vil skje om sertifikatet er utstedt til en annen virksomhet eller hvis det ikke er et virksomhetssertifikat. Virksomhetssertifikat kan skaffes fra Buypass eller Commfides..
        /// </summary>
        internal static string CertificateNotIssuedToOrganization {
            get {
                return ResourceManager.GetString("CertificateNotIssuedToOrganization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to er ugyldig, fordi lengden på kjeden er 1, noe som betyr at sertifikatet er selvsignert. Det må brukes et sertifikat utstedt av en gyldig sertifikatutsteder..
        /// </summary>
        internal static string CertificateSelfSignedErrorResult {
            get {
                return ResourceManager.GetString("CertificateSelfSignedErrorResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sertifikat med Subject &apos;{0:certificateSubject}&apos; og Thumbprint &apos;{1:certificateThumbprint}&apos; {2:certificateExtraInfo}.
        /// </summary>
        internal static string CertificateShortDescription {
            get {
                return ResourceManager.GetString("CertificateShortDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validering av {0:certificateShortDescription} feilet.
        ///Dette skjer fordi kjeden ble bygd med følgende sertifikater: 
        ///{1:chainAsString}, men kun følgende er godkjent for å bygge kjeden:
        ///{2:validatorCertificatesAsString}. Dette skjer som oftest om sertifikater blir hentet fra Certificate Store på Windows, og det tillates ikke under validering. Det er kun gyldig å bygge en kjede med sertifikatene som blir sendt inn i validatoren..
        /// </summary>
        internal static string CertificateUsedExternalResult {
            get {
                return ResourceManager.GetString("CertificateUsedExternalResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to er et gyldig sertifikat..
        /// </summary>
        internal static string CertificateValidResult {
            get {
                return ResourceManager.GetString("CertificateValidResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attributtet PrefixList er ugyldig - Verdien  er ugyldig i henhold til datatypen http://www.w3.org/2001/XMLSchema:NMTOKENS - Attributtverdien kan ikke være tom..
        /// </summary>
        internal static string ToleratedPrefixListError {
            get {
                return ResourceManager.GetString("ToleratedPrefixListError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Det er en feil hvis det finnes et medlem av attributtet som bruker en typedefinisjon med typen xs:ID eller avledet fra xs:ID og et annet attributt med typen xs:ID tilsvarer et attributtjokertegn..
        /// </summary>
        internal static string ToleratedXsdIdError {
            get {
                return ResourceManager.GetString("ToleratedXsdIdError", resourceCulture);
            }
        }
    }
}

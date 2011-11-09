//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4961
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.SiteVerification.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class SiteverificationWebResourceGettokenRequest {
        
        private SiteverificationWebResourceGettokenRequest.SiteData site;
        
        private string verificationMethod;
        
        /// <summary>The site for which a verification token will be generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual SiteverificationWebResourceGettokenRequest.SiteData Site {
            get {
                return this.site;
            }
            set {
                this.site = value;
            }
        }
        
        /// <summary>The verification method that will be used to verify this site. For sites, &apos;FILE&apos; or &apos;META&apos; methods may be used. For domains, only &apos;DNS&apos; may be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationMethod")]
        public virtual string VerificationMethod {
            get {
                return this.verificationMethod;
            }
            set {
                this.verificationMethod = value;
            }
        }
        
        /// <summary>The site for which a verification token will be generated.</summary>
        public class SiteData {
            
            private string identifier;
            
            private string type;
            
            /// <summary>The site identifier. If the type is set to SITE, the identifier is a URL. If the type is set to INET_DOMAIN, the site identifier is a domain name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("identifier")]
            public virtual string Identifier {
                get {
                    return this.identifier;
                }
                set {
                    this.identifier = value;
                }
            }
            
            /// <summary>The type of resource to be verified. Can be SITE or INET_DOMAIN (domain name).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type {
                get {
                    return this.type;
                }
                set {
                    this.type = value;
                }
            }
        }
    }
    
    public class SiteverificationWebResourceGettokenResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private string method;
        
        private string token;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>The verification method to use in conjunction with this token. For FILE, the token should be placed in the top-level directory of the site, stored inside a file of the same name. For META, the token should be placed in the HEAD tag of the default page that is loaded for the site. For DNS, the token should be placed in a TXT record of the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method {
            get {
                return this.method;
            }
            set {
                this.method = value;
            }
        }
        
        /// <summary>The verification token. The token must be placed appropriately in order for verification to succeed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token {
            get {
                return this.token;
            }
            set {
                this.token = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
    
    public class SiteverificationWebResourceListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<SiteverificationWebResourceResource> items;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>The list of sites that are owned by the authenticated user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<SiteverificationWebResourceResource> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
    
    public class SiteverificationWebResourceResource : Google.Apis.Requests.IDirectResponseSchema {
        
        private string id;
        
        private IList<System.String> owners;
        
        private SiteverificationWebResourceResource.SiteData site;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>The string used to identify this site. This value should be used in the &quot;id&quot; portion of the REST URL for the Get, Update, and Delete operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>The email addresses of all verified owners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owners")]
        public virtual IList<System.String> Owners {
            get {
                return this.owners;
            }
            set {
                this.owners = value;
            }
        }
        
        /// <summary>The address and type of a site that is verified or will be verified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual SiteverificationWebResourceResource.SiteData Site {
            get {
                return this.site;
            }
            set {
                this.site = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        /// <summary>The address and type of a site that is verified or will be verified.</summary>
        public class SiteData {
            
            private string identifier;
            
            private string type;
            
            /// <summary>The site identifier. If the type is set to SITE, the identifier is a URL. If the type is set to INET_DOMAIN, the site identifier is a domain name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("identifier")]
            public virtual string Identifier {
                get {
                    return this.identifier;
                }
                set {
                    this.identifier = value;
                }
            }
            
            /// <summary>The site type. Can be SITE or INET_DOMAIN (domain name).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type {
                get {
                    return this.type;
                }
                set {
                    this.type = value;
                }
            }
        }
    }
}
namespace Google.Apis.SiteVerification.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class SiteVerificationService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"siteVerification:v1\",\"name\":\"siteVerifi" +
            "cation\",\"version\":\"v1\",\"title\":\"Google Site Verification API\",\"description\":\"Let" +
            "s you programatically verify ownership of websites or domains with Google.\",\"ico" +
            "ns\":{\"x16\":\"http://www.google.com/images/icons/product/search-16.gif\",\"x32\":\"htt" +
            "p://www.google.com/images/icons/product/search-32.gif\"},\"documentationLink\":\"htt" +
            "p://code.google.com/apis/siteverification/\",\"labels\":[\"labs\"],\"protocol\":\"rest\"," +
            "\"basePath\":\"/siteVerification/v1/\",\"parameters\":{\"alt\":{\"type\":\"string\",\"descrip" +
            "tion\":\"Data format for the response.\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDesc" +
            "riptions\":[\"Responses with Content-Type of application/json\"],\"location\":\"query\"" +
            "},\"fields\":{\"type\":\"string\",\"description\":\"Selector specifying which fields to i" +
            "nclude in a partial response.\",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"descr" +
            "iption\":\"API key. Your API key identifies your project and provides you with API" +
            " access, quota, and reports. Required unless you provide an OAuth 2.0 token.\",\"l" +
            "ocation\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token " +
            "for the current user.\",\"location\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"desc" +
            "ription\":\"Returns response with indentations and line breaks.\",\"default\":\"false\"" +
            ",\"location\":\"query\"},\"userIp\":{\"type\":\"string\",\"description\":\"IP address of the " +
            "site where the request originates. Use this if you want to enforce per-user limi" +
            "ts.\",\"location\":\"query\"}},\"auth\":{\"oauth2\":{\"scopes\":{\"https://www.googleapis.co" +
            "m/auth/siteverification\":{\"description\":\"Manage the list of sites and domains yo" +
            "u control\"}}}},\"schemas\":{\"SiteverificationWebResourceGettokenRequest\":{\"id\":\"Si" +
            "teverificationWebResourceGettokenRequest\",\"type\":\"object\",\"properties\":{\"site\":{" +
            "\"type\":\"object\",\"description\":\"The site for which a verification token will be g" +
            "enerated.\",\"properties\":{\"identifier\":{\"type\":\"string\",\"description\":\"The site i" +
            "dentifier. If the type is set to SITE, the identifier is a URL. If the type is s" +
            "et to INET_DOMAIN, the site identifier is a domain name.\"},\"type\":{\"type\":\"strin" +
            "g\",\"description\":\"The type of resource to be verified. Can be SITE or INET_DOMAI" +
            "N (domain name).\"}}},\"verificationMethod\":{\"type\":\"string\",\"description\":\"The ve" +
            "rification method that will be used to verify this site. For sites, \'FILE\' or \'M" +
            "ETA\' methods may be used. For domains, only \'DNS\' may be used.\"}}},\"Siteverifica" +
            "tionWebResourceGettokenResponse\":{\"id\":\"SiteverificationWebResourceGettokenRespo" +
            "nse\",\"type\":\"object\",\"properties\":{\"method\":{\"type\":\"string\",\"description\":\"The " +
            "verification method to use in conjunction with this token. For FILE, the token s" +
            "hould be placed in the top-level directory of the site, stored inside a file of " +
            "the same name. For META, the token should be placed in the HEAD tag of the defau" +
            "lt page that is loaded for the site. For DNS, the token should be placed in a TX" +
            "T record of the domain.\"},\"token\":{\"type\":\"string\",\"description\":\"The verificati" +
            "on token. The token must be placed appropriately in order for verification to su" +
            "cceed.\"}}},\"SiteverificationWebResourceListResponse\":{\"id\":\"SiteverificationWebR" +
            "esourceListResponse\",\"type\":\"object\",\"properties\":{\"items\":{\"type\":\"array\",\"desc" +
            "ription\":\"The list of sites that are owned by the authenticated user.\",\"items\":{" +
            "\"$ref\":\"SiteverificationWebResourceResource\"}}}},\"SiteverificationWebResourceRes" +
            "ource\":{\"id\":\"SiteverificationWebResourceResource\",\"type\":\"object\",\"properties\":" +
            "{\"id\":{\"type\":\"string\",\"description\":\"The string used to identify this site. Thi" +
            "s value should be used in the \\\"id\\\" portion of the REST URL for the Get, Update" +
            ", and Delete operations.\"},\"owners\":{\"type\":\"array\",\"description\":\"The email add" +
            "resses of all verified owners.\",\"items\":{\"type\":\"string\"}},\"site\":{\"type\":\"objec" +
            "t\",\"description\":\"The address and type of a site that is verified or will be ver" +
            "ified.\",\"properties\":{\"identifier\":{\"type\":\"string\",\"description\":\"The site iden" +
            "tifier. If the type is set to SITE, the identifier is a URL. If the type is set " +
            "to INET_DOMAIN, the site identifier is a domain name.\"},\"type\":{\"type\":\"string\"," +
            "\"description\":\"The site type. Can be SITE or INET_DOMAIN (domain name).\"}}}}}},\"" +
            "resources\":{\"webResource\":{\"methods\":{\"delete\":{\"id\":\"siteVerification.webResour" +
            "ce.delete\",\"path\":\"webResource/{id}\",\"httpMethod\":\"DELETE\",\"description\":\"Relinq" +
            "uish ownership of a website or domain.\",\"parameters\":{\"id\":{\"type\":\"string\",\"des" +
            "cription\":\"The id of a verified site or domain.\",\"required\":true,\"location\":\"pat" +
            "h\"}},\"parameterOrder\":[\"id\"],\"scopes\":[\"https://www.googleapis.com/auth/siteveri" +
            "fication\"]},\"get\":{\"id\":\"siteVerification.webResource.get\",\"path\":\"webResource/{" +
            "id}\",\"httpMethod\":\"GET\",\"description\":\"Get the most current data for a website o" +
            "r domain.\",\"parameters\":{\"id\":{\"type\":\"string\",\"description\":\"The id of a verifi" +
            "ed site or domain.\",\"required\":true,\"location\":\"path\"}},\"parameterOrder\":[\"id\"]," +
            "\"response\":{\"$ref\":\"SiteverificationWebResourceResource\"},\"scopes\":[\"https://www" +
            ".googleapis.com/auth/siteverification\"]},\"getToken\":{\"id\":\"siteVerification.webR" +
            "esource.getToken\",\"path\":\"token\",\"httpMethod\":\"GET\",\"description\":\"Get a verific" +
            "ation token for placing on a website or domain.\",\"parameters\":{\"identifier\":{\"ty" +
            "pe\":\"string\",\"description\":\"The URL or domain to verify.\",\"location\":\"query\"},\"t" +
            "ype\":{\"type\":\"string\",\"description\":\"Type of resource to verify. Can be \'site\' (" +
            "URL) or \'inet_domain\' (domain name).\",\"location\":\"query\"},\"verificationMethod\":{" +
            "\"type\":\"string\",\"description\":\"The method to use for verifying a site or domain." +
            "\",\"location\":\"query\"}},\"response\":{\"$ref\":\"SiteverificationWebResourceGettokenRe" +
            "sponse\"},\"scopes\":[\"https://www.googleapis.com/auth/siteverification\"]},\"insert\"" +
            ":{\"id\":\"siteVerification.webResource.insert\",\"path\":\"webResource\",\"httpMethod\":\"" +
            "POST\",\"description\":\"Attempt verification of a website or domain.\",\"parameters\":" +
            "{\"verificationMethod\":{\"type\":\"string\",\"description\":\"The method to use for veri" +
            "fying a site or domain.\",\"required\":true,\"location\":\"query\"}},\"parameterOrder\":[" +
            "\"verificationMethod\"],\"request\":{\"$ref\":\"SiteverificationWebResourceResource\"},\"" +
            "response\":{\"$ref\":\"SiteverificationWebResourceResource\"},\"scopes\":[\"https://www." +
            "googleapis.com/auth/siteverification\"]},\"list\":{\"id\":\"siteVerification.webResour" +
            "ce.list\",\"path\":\"webResource\",\"httpMethod\":\"GET\",\"description\":\"Get the list of " +
            "your verified websites and domains.\",\"response\":{\"$ref\":\"SiteverificationWebReso" +
            "urceListResponse\"},\"scopes\":[\"https://www.googleapis.com/auth/siteverification\"]" +
            "},\"patch\":{\"id\":\"siteVerification.webResource.patch\",\"path\":\"webResource/{id}\",\"" +
            "httpMethod\":\"PATCH\",\"description\":\"Modify the list of owners for your website or" +
            " domain. This method supports patch semantics.\",\"parameters\":{\"id\":{\"type\":\"stri" +
            "ng\",\"description\":\"The id of a verified site or domain.\",\"required\":true,\"locati" +
            "on\":\"path\"}},\"parameterOrder\":[\"id\"],\"request\":{\"$ref\":\"SiteverificationWebResou" +
            "rceResource\"},\"response\":{\"$ref\":\"SiteverificationWebResourceResource\"},\"scopes\"" +
            ":[\"https://www.googleapis.com/auth/siteverification\"]},\"update\":{\"id\":\"siteVerif" +
            "ication.webResource.update\",\"path\":\"webResource/{id}\",\"httpMethod\":\"PUT\",\"descri" +
            "ption\":\"Modify the list of owners for your website or domain.\",\"parameters\":{\"id" +
            "\":{\"type\":\"string\",\"description\":\"The id of a verified site or domain.\",\"require" +
            "d\":true,\"location\":\"path\"}},\"parameterOrder\":[\"id\"],\"request\":{\"$ref\":\"Siteverif" +
            "icationWebResourceResource\"},\"response\":{\"$ref\":\"SiteverificationWebResourceReso" +
            "urce\"},\"scopes\":[\"https://www.googleapis.com/auth/siteverification\"]}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "siteVerification";
        
        private const string BaseUri = "https://www.googleapis.com/siteVerification/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        protected SiteVerificationService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.webResource = new WebResourceResource(this);
        }
        
        public SiteVerificationService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public SiteVerificationService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(SiteVerificationService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(SiteVerificationService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
        
        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes {
            
            /// <summary>Manage the list of sites and domains you control</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/siteverification")]
            Siteverification,
        }
    }
    
    public class WebResourceResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "webResource";
        
        public WebResourceResource(SiteVerificationService service) {
            this.service = service;
        }
        
        /// <summary>Relinquish ownership of a website or domain.</summary>
        /// <param name="id">Required - The id of a verified site or domain.</param>
        public virtual DeleteRequest Delete(string id) {
            return new DeleteRequest(service, id);
        }
        
        /// <summary>Get the most current data for a website or domain.</summary>
        /// <param name="id">Required - The id of a verified site or domain.</param>
        public virtual GetRequest Get(string id) {
            return new GetRequest(service, id);
        }
        
        /// <summary>Get a verification token for placing on a website or domain.</summary>
        public virtual GetTokenRequest GetToken() {
            return new GetTokenRequest(service);
        }
        
        /// <summary>Attempt verification of a website or domain.</summary>
        /// <param name="verificationMethod">Required - The method to use for verifying a site or domain.</param>
        public virtual InsertRequest Insert(Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource body, string verificationMethod) {
            return new InsertRequest(service, body, verificationMethod);
        }
        
        /// <summary>Get the list of your verified websites and domains.</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Modify the list of owners for your website or domain. This method supports patch semantics.</summary>
        /// <param name="id">Required - The id of a verified site or domain.</param>
        public virtual PatchRequest Patch(Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource body, string id) {
            return new PatchRequest(service, body, id);
        }
        
        /// <summary>Modify the list of owners for your website or domain.</summary>
        /// <param name="id">Required - The id of a verified site or domain.</param>
        public virtual UpdateRequest Update(Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource body, string id) {
            return new UpdateRequest(service, body, id);
        }
        
        public class DeleteRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string id;
            
            public DeleteRequest(Google.Apis.Discovery.IRequestProvider service, string id) : 
                    base(service) {
                this.id = id;
            }
            
            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "delete";
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource> {
            
            private string id;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string id) : 
                    base(service) {
                this.id = id;
            }
            
            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class GetTokenRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceGettokenResponse> {
            
            private string identifier;
            
            private string type;
            
            private string verificationMethod;
            
            public GetTokenRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>The URL or domain to verify.</summary>
            [Google.Apis.Util.RequestParameterAttribute("identifier")]
            public virtual string Identifier {
                get {
                    return this.identifier;
                }
                set {
                    this.identifier = value;
                }
            }
            
            /// <summary>Type of resource to verify. Can be 'site' (URL) or 'inet_domain' (domain name).</summary>
            [Google.Apis.Util.RequestParameterAttribute("type")]
            public virtual string Type {
                get {
                    return this.type;
                }
                set {
                    this.type = value;
                }
            }
            
            /// <summary>The method to use for verifying a site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("verificationMethod")]
            public virtual string VerificationMethod {
                get {
                    return this.verificationMethod;
                }
                set {
                    this.verificationMethod = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "getToken";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource> {
            
            private string verificationMethod;
            
            private Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource bodyValue;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource body, string verificationMethod) : 
                    base(service) {
                this.Body = body;
                this.verificationMethod = verificationMethod;
            }
            
            /// <summary>The method to use for verifying a site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("verificationMethod")]
            public virtual string VerificationMethod {
                get {
                    return this.verificationMethod;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "insert";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceListResponse> {
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
        
        public class PatchRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource> {
            
            private string id;
            
            private Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource bodyValue;
            
            public PatchRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource body, string id) : 
                    base(service) {
                this.Body = body;
                this.id = id;
            }
            
            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "patch";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class UpdateRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource> {
            
            private string id;
            
            private Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource bodyValue;
            
            public UpdateRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource body, string id) : 
                    base(service) {
                this.Body = body;
                this.id = id;
            }
            
            /// <summary>The id of a verified site or domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id")]
            public virtual string Id {
                get {
                    return this.id;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.SiteVerification.v1.Data.SiteverificationWebResourceResource Body {
                get {
                    return this.bodyValue;
                }
                set {
                    this.bodyValue = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webResource";
                }
            }
            
            protected override string MethodName {
                get {
                    return "update";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
    
    public partial class SiteVerificationService {
        
        private const string Resource = "";
        
        private WebResourceResource webResource;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual WebResourceResource WebResource {
            get {
                return this.webResource;
            }
        }
    }
}
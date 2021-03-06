using System;

namespace Microsoft.AspNet.WebApi.Owin
{
	/// <summary>
	/// Standard keys and values for use within the OWIN interfaces
	/// </summary>
	
	internal static class Constants
	{
		
		public const string CallCancelledKey = "owin.CallCancelled";

		
		public const string ClientCertifiateKey = "ssl.ClientCertificate";

		
		public const string HttpRequestProtocolKey = "owin.RequestProtocol";

		
		public const string HttpResponseProtocolKey = "owin.ResponseProtocol";

		
		public const string IsLocalKey = "host.IsLocal";

		
		public const string MSClientCertificateKey = "MS_ClientCertificate";

		
		public const string MSIsLocalKey = "MS_IsLocal";

		
		public const string OwinVersion = "1.0";

		
		public const string RequestBodyKey = "owin.RequestBody";

		
		public const string RequestEnvironmentKey = "owin.Environment";

		
		public const string RequestHeadersKey = "owin.RequestHeaders";

		
		public const string RequestMethodKey = "owin.RequestMethod";

		
		public const string RequestPathBaseKey = "owin.RequestPathBase";

		
		public const string RequestPathKey = "owin.RequestPath";

		
		public const string RequestQueryStringKey = "owin.RequestQueryString";

		
		public const string RequestSchemeKey = "owin.RequestScheme";

		
		public const string ResponseBodyKey = "owin.ResponseBody";

		
		public const string ResponseHeadersKey = "owin.ResponseHeaders";

		
		public const string ResponseReasonPhraseKey = "owin.ResponseReasonPhrase";

		
		public const string ResponseStatusCodeKey = "owin.ResponseStatusCode";

		
		public const string SendFileAsyncKey = "sendfile.SendAsync";

		
		public const string VersionKey = "owin.Version";
	}
}

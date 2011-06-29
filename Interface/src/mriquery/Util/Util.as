package mriquery.Util{
	
	import flash.net.URLRequest;
	import flash.net.navigateToURL;
	
	
	public class Util{
		
		public function Util(){}
		
		public static function abrirLinkNovaJanela(url:String):void {
			var urlRequest:URLRequest = new URLRequest(url);
			navigateToURL(urlRequest, "_blank");
		}
		
		public static function siteCorreio():void {
			
			Util.abrirLinkNovaJanela(Constantes.SITE_CORREIO);
		}

	}
}
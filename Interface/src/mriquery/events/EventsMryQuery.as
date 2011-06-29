package mriquery.events{
	
	import mx.events.FlexEvent;
	
	public class EventsMryQuery extends FlexEvent {
		
		public var object:Object;
				
		
		public static const LOGIN:String = "loginRealizado";
		public static const LOGOUT:String = "logoutRealizado";
		public static const ATUALIZAR_DG_PERFIL:String = "atualizaDgPerfil";
								
		public function EventsMryQuery(type:String, bubbles:Boolean=true, cancelable:Boolean=false, dados:Object = null) {
			super(type, bubbles, cancelable);
			this.object = dados;
		}
		
		public function get dados():Object {
			return object; 
		}

	}
}



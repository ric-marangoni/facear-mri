package mriquery.Util
{
	public class Pessoa
	{
		
		public var id:int;
		public var nome:String;
		public var email:String ;
		public var telefone:String  ;
		public var celular:String ;
		public var status:String ;	
		
		public function Pessoa(  nome:String ,  email:String ,  telefone:String ,  celular:String , status:String  , id:int)
		{
			this.id = id;
			this.nome = nome;
			this.email = email;
			this.telefone = telefone;
			this.celular = celular;
			this.status = status;
		}

	}
}
package mriquery.actionScript.entidades
{
	import mriquery.actionScript.entidades.Endereco;
	
	[RemoteClass(alias="br.com.entidades.Pessoa")]
	public class Pessoa 
	{
		private var senha:String;
		private var login:String;
		private var Status:String;
		private var emailPessoal:String;
		private var emailComercial:String;
		private var telefoneComercial:Number;
		private var telefoneCelular:Number;
		private var telefoneResidencial:Number;
		private var dataCadastro:Date;
		private var endereco:Endereco;
		
		public function Pessoa(){ }

	}
}
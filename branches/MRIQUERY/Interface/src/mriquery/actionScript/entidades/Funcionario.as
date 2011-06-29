package mriquery.actionScript.entidades
{
	
	[RemoteClass(alias="br.com.entidades.Funcionario")]
	public class Funcionario
	{
		private var id:int;
		private var perfil:Perfil;
		private var dataAdminssao:Date;
		private var dataDemissao:Date;
		private var pessoaFisica:PessoaFisica;
		
		public function Funcionario(){}

	}
}
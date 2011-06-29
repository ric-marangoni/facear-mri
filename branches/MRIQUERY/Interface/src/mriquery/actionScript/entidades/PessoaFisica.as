package mriquery.actionScript.entidades
{
    [RemoteClass(alias="br.com.entidades.PessoaFisica")]
	public class PessoaFisica extends Pessoa
	{
		private var nome:String;
		private var sexo:String;
		private var dataNascimento:Date;
		private var cpf:Number;
		
		public function PessoaFisica(){	}

	}
}
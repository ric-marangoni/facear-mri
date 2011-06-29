package mriquery.actionScript.entidades
{
	import mx.collections.ArrayCollection;
	
	[RemoteClass(alias="br.com.entidades.Editora")]
	public class Editora extends PessoaJuridica
	{
		private var produto:ArrayCollection;
		
		
		public function Editora()
		{
		}

	}
}
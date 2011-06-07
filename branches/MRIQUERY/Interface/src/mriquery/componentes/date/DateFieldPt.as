package mriquery.componentes.date
{
	import mx.controls.DateField;
	import mx.formatters.DateFormatter;
	
	public class DateFieldPt extends DateField
	{
		
		public var ptFormatter:DateFormatter = new DateFormatter();
		
		public function DateFieldPt() {

			super();

			monthNames = ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outbro', 'Novembro', 'Dezembro'];
			dayNames = ['D', 'S', 'T', 'Q', 'Q', 'S', 'S'];
			yearNavigationEnabled = true;
			formatString = 'DD/MM/YYYY';
			ptFormatter.formatString = 'DD/MM/YYYY';
			restrict="0-9./\-";

		}
		
		public function get datePt():String{
			return ptFormatter.format(selectedDate);
		}

	}
}
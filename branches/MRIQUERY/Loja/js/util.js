jQuery(document).ready(
	function(){		
	    
		var tamanhoMenu = jQuery('#menu li').length;
		jQuery('#menu li a').eq(0).css('border', 'none');			

		var Banner = jQuery('.jcarousel-banner');
		
		if(Banner.length > 0){
				Banner.cycle({
				fx: 'fade',
				speed: 2000,
				timeout: 2000,
				prev : '.slide-prev',
				next : '.slide-next'	
			});
		}

		jQuery('#link-fies').click(function(){
			window.open("http://www1.caixa.gov.br/popup/home/popup_home_4.asp", "mywindow", "menubar=1, width=750, height=600");
		});

		jQuery(function(){
   
			jQuery("*[rel=tooltip]").hover(
				function(e){
					 jQuery("body").append('<div class="tooltip">'+jQuery(this).attr('title')+'</div>');
					 jQuery('.tooltip').css({
						 top : e.pageY - 60,
						 left : e.pageX - 90
					 }).fadeIn();
					  
				}, function(){
					  jQuery('.tooltip').remove();
				}).mousemove(function(e){
				  jQuery('.tooltip').css({
					top : e.pageY - 60,
					left : e.pageX - 90
				});
			});

		});		
	}
);
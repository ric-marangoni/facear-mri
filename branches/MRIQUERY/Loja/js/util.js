jQuery(document).ready(
	function(){		
	    
	    var er = new RegExp("Checkout.aspx");
	    
	    if(er.test(window.location)){
	        jQuery('#side-bar').hide();
	        jQuery('#box-principal').css('width', '100%');
	        jQuery('.lista-carrinho table').attr('rules', '');;
	    }
	    
	    var carrinho = document.getElementById('ctl00_cart_info');
        carrinho.innerHtml = '<small>Você tem <strong>50</strong></small>';
	   
	    	
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
		
		jQuery(function(){
		    
		    jQuery("*[rel=obrigatorio]").blur(function(){
		        if(jQuery(this).val() == 0){
		            jQuery(this).css('border-color', 'red');	            
		        }else{
		            jQuery(this).css('border-color', 'none');
		        }
		    });
		    
		});		
	}
);
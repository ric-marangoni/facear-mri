jQuery(document).ready(
	function(){		
	    
	    var erCheckout = new RegExp("Checkout.aspx");
	    var erLogin = new RegExp("Login.aspx");
	    var erPag = new RegExp("Pagamento.aspx");
	    
	    if(erCheckout.test(window.location) || erLogin.test(window.location) ||  erPag.test(window.location)){
	        jQuery('#side-bar').hide();
	        jQuery('#box-principal').css('width', '100%');
	        jQuery('.lista-carrinho table').attr('rules', '');;
	    }
	        	
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
		        if(jQuery(this).val() == 0 || jQuery(this).val() == "__/__/____" || jQuery(this).val() == "___.___.___-__" || jQuery(this).val() == "__.___-___"){
		            jQuery(this).css('border-color', '#B72E00');	            
		        }else{
		            jQuery(this).css('border-color', '#999');
		        }
		    });
		    
		    jQuery("#ctl00_ContentPlaceHolder1_cdrDataNascimento").mask("99/99/9999",{placeholder: "_"});
		    jQuery("#ctl00_ContentPlaceHolder1_cdrCpf").mask("999.999.999-99",{placeholder: "_"});
		    jQuery("#ctl00_ContentPlaceHolder1_cdrTelResidencial").mask("(99)9999-9999",{placeholder: "_"});
		    jQuery("#ctl00_ContentPlaceHolder1_cdrTelCelular").mask("(99)9999-9999",{placeholder: "_"});
		    jQuery("#ctl00_ContentPlaceHolder1_cdrTelComercial").mask("(99)9999-9999",{placeholder: "_"});
		    jQuery("#ctl00_ContentPlaceHolder1_cdrCep").mask("99.999-999",{placeholder: "_"});
		    jQuery("#ctl00_ContentPlaceHolder1_cdrAlternativoCep").mask("99.999-999",{placeholder: "_"});

		    
		});		
	}
);
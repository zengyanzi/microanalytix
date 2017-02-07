# microanalytix
nopcommerce

add keywords in searchbox  

2017-02-07
path：theme/customMicroanalytix/views/shared/headers.cshtml
add in <div class="search-box"> the following codes as below
   <div>You may like:&nbsp;&nbsp;
            <ul>
                <li style="width:100px;"><a href="search?q=Filter+paper" target="_blank">Filter Paper</a></li>
                <li style="width:100px;"><a href="search?q=Filter+paper" target="_blank">Membrane filter</a></li>
                <li style="width:100px;"><a href="search?q=Filter+paper" target="_blank">Syringe filter</a></li>
            </ul>
        </div>
        
 how to add hover for Aboutus  

2017-01-31 07:02:35
    <li class="has-mega-menu"><a href="@Url.RouteUrl("Topic", new {SeName = Html.GetTopicSeName("aboutus") })">ABOUTUS</a>

          <div class="top-menu-triangle"></div>
        <div class="mega-menu">
            <div class="row">
                <div class="col-xs-4 col-md-4 "  >
                    <div class="img-holder">
                        <img style="width:50%;height:50%;float:left" src="../../Content/images/who.png" >
                        <ul style="float:left;margin-top:5px;text-align:left">
                            <li style="list-style:none;color:#757b81">MicroAnalytix is an Australian owned laboratory supply company which was established in 1988. Since then, the organisation has grown to providing laboratory products ...<a href="about-us" style="text-decoration:underline">Learn more</a></li>
                        </ul>
                       </a>
                    </div>
                    
                </div>
                <div class="col-xs-4 col-md-4">
                    <div class="img-holder">
                        <img style="width:50%;height:50%;float:left" src="../../Content/images/what.png" >
                        <ul style="float:left;margin-top:5px;text-align:left ">
                            <li style="list-style:none;color:#757b81">We have purpose built offices in Melbourne, Queensland with our head office and warehouse located in Sydney. Auckland, in New Zealand's North Island is our NZ head office ...<a href="about-us" style="text-decoration:underline">Learn more</a></li>

                        </ul>
                       </a>
                    </div>
                </div>
                <div class="col-xs-4 col-md-4" >
                    <div class="img-holder">
                        <img style="width:50%;height:50%;float:left" src="../../Content/images/about.png" >
                        <ul style="float:left;margin-top:5px;text-align:left">
                            <li style="list-style:none;color:#757b81">More recently, Microanalytix has been focusing on the introduction of new product lines and have become sort after technical advisors on numerous applications and products...<a href="about-us" style="text-decoration:underline">Learn more</a></li>
    
                        </ul>
                       </a>
                    </div>

            </div>
        </div>
        
add hover to promotion  

2017-01-24 05:29:25
1.add class="has-mega-menu" to li 
2.add div class="mega-menu"
3.add class="row" div 
4.add class="col-xs-4 col-md-4"  //here is the bootstrap desigining ,could be changed according to the different layout
5.add class="img-holder"
6.add a 
7.add img
8.add ul and li
here is the code 
<li class="has-mega-menu"><a href="@Url.RouteUrl("Topic", new {SeName = Html.GetTopicSeName("promotions") })">PROMOTIONS</a>

       <div class="top-menu-triangle"></div>
        <div class="mega-menu">
            <div class="row">
                <div class="col-xs-4 col-md-4 "  >
                    <div class="img-holder">
                        <a href="products-on-promotion">
                        <img style="width:50%;height:50%;float:left" src="../../Content/images/step1.png" >
                        <ul style="float:left;margin-top:5px;text-align:left">
                            <li style="list-style:none;color:#757b81">Enjoy our website</li>
                            <li style="list-style:none;color:#757b81">Enjoy our promotion</li>
                            <li style="list-style:none;color:#757b81">Enjoy your account</li>
                        </ul>
                       </a>
                    </div>
                    
                </div>
                <div class="col-xs-4 col-md-4">
                    <div class="img-holder">
                        <a href="products-on-promotion">
                        <img style="width:50%;height:50%;float:left" src="../../Content/images/step2.png" >
                        <ul style="float:left;margin-top:5px;text-align:left ">
                            <li style="list-style:none;color:#757b81">Find your items</li>
                            <li style="list-style:none;color:#757b81">Add to shopping cart</li>
                            <li style="list-style:none;color:#757b81">Just check out</li>
                        </ul>
                       </a>
                    </div>
                </div>
                <div class="col-xs-4 col-md-4" >
                    <div class="img-holder">
                        <a href="products-on-promotion">
                        <img style="width:50%;height:50%;float:left" src="../../Content/images/step3.png" >
                        <ul style="float:left;margin-top:5px;text-align:left">
                            <li style="list-style:none;color:#757b81">Convenient</li>
                            <li style="list-style:none;color:#757b81">Fast</li>
                            <li style="list-style:none;color:#757b81">Easy</li>
                        </ul>
                       </a>
                    </div>

            </div>
        </div>

   </li>
   
   
solve the problem of Responsive Layout  

2017-01-18 09:51:41
1.add in styles.css
.master-wrappermain{
    display: -webkit-flex;
    display: -moz-flex;
    display: -ms-flex;
    display: -o-flex;
    display: flex;
    justify-content: center;
    align-items: center;
}
2.remove the width off .master-wrapper-main
/*  width:75%;
  margin:0 auto;
  max-width:1170px;
  background:#fff;*/
3.add div in root :views/shared/_root.cshtml
     <div class="master-wrappermain">
            <div class="master-wrapper-main clearfix">
                @RenderBody()
            </div>
        </div>
upload to FTP and test 
considering the IE browser 
change with another way
1.add text-align in master-wrapper-main
2.add .master-wrapper-main .side-2 li{
	text-align: left;
}
3.add in master-wrappermain
master-wrappermain{
	text-align: center;
}

.master-wrapper-main {
  font-family: arial,helvetica,sans-serif;
  color: #5C5B5B;
  display: inline-block;
  /*width:75%;
  margin:0 auto;
  max-width:1170px;*/
  background:#fff;
}

/* one column master page */
.master-wrapper-main .center-1 {
  float: left;
  width: 910px;
  min-height: 400px;
  padding: 10px;
  background: #FFF;
  display: inline;
  border-radius: 5px;
}

/* two column master page */
.master-wrapper-main .side-2 {
  float: left;
  width: 190px;
  margin: 10px 0  10px 5px;
  display: inline;
}
.master-wrapper-main .side-2 li{
	text-align: left;
}
update 24012017
due to the modify of master-wrappermain{
	text-align: center;
}
it effected other layout including:one column;two column and three column
we need to add text-align into them.

nopcommerce image hover scale
2016-09-19 22:35
.product-grid .product-item .picture:hover img {
      margin-left: auto;
      margin-right: auto; 
      transition: all 0.2s;
      -webkit-transition: all 0.2s;
      transform: scale(1.2);
      -webkit-transform: scale(1.2);
     }

add this code in css

how to change the time of novisilder in nopcommerce  

2016-08-02 10:49:35
go to the path plugins/widget.nivoslider/scripts/jquery.nivo.slider.js
change the pause time
the default pause time is 5000
then we could change to 2000,which test is good. 

how to change the size of image under recently review nopcommerce  

2016-07-29 05:42:41
1.go to nop.web\views\catalog\recentlyviewproductblock.cshtml
2.change the following code
{
                            <div class="product-picture">
                                <a href="@Url.RouteUrl("Product", new { SeName = product.SeName })" title="@product.DefaultPictureModel.Title">
                                    <img class="recentviewimg"alt="@product.DefaultPictureModel.AlternateText" src="@product.DefaultPictureModel.ImageUrl" title="@product.DefaultPictureModel.Title" />
                                </a>
                            </div>
                        }
to 
{
                            <div class="product-picture">
                                <a href="@Url.RouteUrl("Product", new { SeName = product.SeName })" title="@product.DefaultPictureModel.Title">
                                    <img class="recentviewimg"alt="@product.DefaultPictureModel.AlternateText" src="@product.DefaultPictureModel.FullSizeImageUrl" title="@product.DefaultPictureModel.Title" />
                                </a>
                            </div>
                     
the reason is ,if we choose imageUrl,it will load image from thumb but if we choose Fullsizeimageurl,then it will load from full size._______________could be found in nop.web\controllers\catalogcontroller.cs like this below:
 var defaultPictureModel = new PictureModel()
                {
                    ImageUrl = _pictureService.GetPictureUrl(pictures.FirstOrDefault(), defaultPictureSize, !isAssociatedProduct),
                    FullSizeImageUrl = _pictureService.GetPictureUrl(pictures.FirstOrDefault(), 0, !isAssociatedProduct),
                    Title = string.Format(_localizationService.GetResource("Media.Product.ImageLinkTitleFormat.Details"), model.Name),
                    AlternateText = string.Format(_localizationService.GetResource("Media.Product.ImageAlternateTextFormat.Details"), model.Name),
                };
3.add css for the size of image
class="recentviewimg"
and add css in theme 
.block-recently-viewed-products li {
  background: none;
  height: 55px;
  clear: both;
  margin:0px;
  border-bottom: 1px solid #e5e5e5;
}

.block-recently-viewed-products li.last {
  border-bottom: none;
}

.block-recently-viewed-products .product-picture {
  float: left;
  height: 55px;
  width: 55px;
  margin: 0px;
  padding:0px;
}
.recentviewimg
{
    float: left;
    height: 50px;
    width: 50px;
    margin-right: 5px;
    padding:0px;
}

how to update nopcommerce homepage layout  

2016-07-28 16:32:28
1.find this file under the themes/themesname/views/home/index.cshtml
2.change the 
@{
    Layout = "~/Views/Shared/_ColumnsThree.cshtml";
}
3generate
refresh

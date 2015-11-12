<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
           
        }
        .login {
           width: 30%;
        }
       
      
        .logo {
           
            width: 30%;
        }
        .headerTitle {
            font-size: 36px;
            width: 70%;
            text-align: center;
            color: #002063;
        }
         .header {
            
            background-color: #8cf7dd;
        }
        .fontSize20 {
            font-size: 20px;

        }
        .copy {
            width: 70%;
          
            padding: 30px 30px;
        }
        .footer {
            
            
        }
        .container {
            width: 1100px;
            background-color: white;
        }
       
        .content {
            
        }
        .bottomPadding {
            padding-bottom: 20px;
        }
        h1 {
            color: #002063;
        }
        h2 {
            color: #002063;
        }
    </style>
</head>
<body style="margin: 0 auto; display: table; background-color: #ededed;">
    <div class="container">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr class="header">
                <td class="logo"><img src="/properties/images/Logo.png" width="260"/></td>
                <td class="headerTitle"><strong>Ruffco Airlines</strong><br />
                    <span class="fontSize20"><em>&quot;Rough air made easy&quot;</em></span></td>
                
            </tr>
            <tr class="content">
                <td class="login">
                    <h2>Company Jet Reservation login</h2>
                    <div class="bottomPadding"><asp:Button ID="btnLogin" runat="server" PostBackUrl="~/login.aspx" Text="log in" /></div>
                    <div><img src="/properties/images/plane.jpg" width="100%" style="height: 265px"/></div>
                </td>
                <td class="copy">
                    <h1>RuffCo Jet Reservation Page</h1>
                    <p>Lorem ipsum dolor sit amet, pellentesque nonummy consectetuer elit justo neque, massa luctus nulla arcu leo etiam lectus, odio sed pellentesque sed sit, aliquam sit vitae, nibh porttitor dis phasellus. Metus ante quam pede elementum consequat, feugiat ut nibh libero aliquet leo dictum. Aliquam vitae vivamus ornare et ligula eleifend, dolor odio ac lectus conubia, nulla eros quae consequat, odio eu vitae ante id a metus. Risus et amet quis debitis, a amet vel libero euismod wisi, wisi nonummy vel at fringilla in. Wisi suscipit rutrum ante pretium, nec tempor, cursus hendrerit mollitia libero non, metus suscipit varius ullamcorper. Bibendum nulla fusce adipiscing vel augue justo, aliquam sit quis aliquet nibh, eu morbi suscipit sit magnam ac venenatis, wisi commodo mollis interdum rutrum libero scelerisque, metus eu pellentesque praesent sed ac. Id luctus maecenas eleifend a aliquam, donec at in vestibulum. At massa dapibus et tincidunt suscipit vel, amet iaculis nunc vel.
Non venenatis. Potenti a non. Sit facilisi erat viverra in, sapien vestibulum ac phasellus ipsum, placerat qui consequat lobortis mi, interdum ligula magnis nunc amet.</p><p> Integer curabitur ut, ut consectetuer mattis dignissim nulla habitant etiam, aliquam eget ullamcorper elit nunc consectetur. Velit adipiscing imperdiet enim libero. Eu sagittis aliquam praesent, massa lacus ullamcorper phasellus. Quis eros mollis nibh nunc luctus, et volutpat amet id, vitae nibh.</p>
<p>Morbi mauris, tellus maecenas orci tellus fusce cum ligula. Leo imperdiet culpa in. Nullam mauris magna molestie, dolor non metus, consequat neque mi quis sed pede dictum, nunc aliquet non in aliquam. Ipsum vivamus imperdiet arcu convallis iusto sociosqu. Aenean amet et ante eleifend massa sed, ligula libero enim aliquam id, sodales mauris suscipit, aliquam sodales sed diam faucibus ipsum hendrerit, magnis non id. Nam massa est venenatis. Enim curabitur. Nibh at tortor a odio. Quis nibh lorem, wisi varius sapien, mi facilisis sed bibendum luctus dignissim. Nulla iaculis, enim orci lectus sed venenatis magna voluptate.</p></td>
            </tr>

        </table>
    <div style="margin: 0 auto;">
                      <p class="footer" style="float: left;">@copyright 2015</p>
                      <a href="credits.html" style="float:right; padding-top: 10px; ">Credits</a>
                     </div>
    </div>
    </form>
        </div>
</body>
</html>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Concessionaria._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
         <h1>Acquista</h1>
    <form>
 

 <div class="form-group mt-3">
     <label for="DropDownList1">Seleziona Macchina e modello</label>
     <asp:DropDownList ID="DropDownList1" runat="server"  CssClass="form-control" Width="200px">  
     </asp:DropDownList>
       <br />


     <div class="row">

     <label for="Checkbox1">Cambio</label>
     <input id="Checkbox1" type="checkbox" />
        

     <label for="Checkbox2">Pilota automatico</label>
     <input id="Checkbox2" type="checkbox" />          
          

     <div  class="row">
     <label for="Checkbox3">Corso pronto soccorso</label>
     <input id="Checkbox3" type="checkbox" />
           


      <label for="Checkbox4">Navigatore</label>
     <input id="Checkbox4" type="checkbox" />
              


    <label for="Checkbox5">Cerchi in lega</label>
    <input  id="Checkbox5" type="checkbox" />
              
      </div>
    </div>

     <asp:Button ID="Button1" runat="server" Text="Button" onClick="Stampa_Click"/>
     <p id="stampa_selezione">

     </p>

 </div>

    </form>
       
    </main>

</asp:Content>

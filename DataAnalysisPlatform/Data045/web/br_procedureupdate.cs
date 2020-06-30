/*
               File: BR_ProcedureUpdate
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:49.92
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_procedureupdate : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedureupdate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedureupdate( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_ProcedureID )
      {
         this.AV18BR_ProcedureID = aP0_BR_ProcedureID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavVpxsurgeryname = new GXCombobox();
         cmbavVpxradiotherapy = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV18BR_ProcedureID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18BR_ProcedureID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA8T2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8T2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022815164998", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedureupdate.aspx") + "?" + UrlEncode("" +AV18BR_ProcedureID)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_procedure", AV10BR_Procedure);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_procedure", AV10BR_Procedure);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE", AV10BR_Procedure);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE", AV10BR_Procedure);
         }
         GxWebStd.gx_hidden_field( context, "vBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18BR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE8T2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8T2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_procedureupdate.aspx") + "?" + UrlEncode("" +AV18BR_ProcedureID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_ProcedureUpdate" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB8T0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavVpxsurgeryname.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavVpxsurgeryname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavVpxsurgeryname_Internalname, "�Ƿ�����", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavVpxsurgeryname, cmbavVpxsurgeryname_Internalname, StringUtil.RTrim( AV11vPXSurgeryName), 1, cmbavVpxsurgeryname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavVpxsurgeryname.Visible, cmbavVpxsurgeryname.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "", true, "HLP_BR_ProcedureUpdate.htm");
            cmbavVpxsurgeryname.CurrentValue = StringUtil.RTrim( AV11vPXSurgeryName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxsurgeryname_Internalname, "Values", (String)(cmbavVpxsurgeryname.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVdate_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVdate_Internalname, "��������", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVdate_Internalname, context.localUtil.Format(AV12vDate, "9999/99/99"), context.localUtil.Format( AV12vDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVdate_Jsonclick, 0, "AttributeDate", "", "", "", "", edtavVdate_Visible, edtavVdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavVdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavVdate_Visible==0)||(edtavVdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", cmbavVpxradiotherapy.Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavVpxradiotherapy_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavVpxradiotherapy_Internalname, "�Ƿ���ܷ���", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavVpxradiotherapy, cmbavVpxradiotherapy_Internalname, StringUtil.RTrim( AV13vPXRadiotherapy), 1, cmbavVpxradiotherapy_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavVpxradiotherapy.Visible, cmbavVpxradiotherapy.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "", true, "HLP_BR_ProcedureUpdate.htm");
            cmbavVpxradiotherapy.CurrentValue = StringUtil.RTrim( AV13vPXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxradiotherapy_Internalname, "Values", (String)(cmbavVpxradiotherapy.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVradiodate_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVradiodate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVradiodate_Internalname, "��������", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVradiodate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVradiodate_Internalname, context.localUtil.Format(AV14vRadioDate, "9999/99/99"), context.localUtil.Format( AV14vRadioDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVradiodate_Jsonclick, 0, "AttributeDate", "", "", "", "", edtavVradiodate_Visible, edtavVradiodate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavVradiodate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavVradiodate_Visible==0)||(edtavVradiodate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVradiotime_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVradiotime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVradiotime_Internalname, "�����Ƴ�", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVradiotime_Internalname, StringUtil.LTrim( StringUtil.NToC( AV15vRadioTime, 15, 5, ".", "")), ((edtavVradiotime_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV15vRadioTime, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV15vRadioTime, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVradiotime_Jsonclick, 0, "Attribute", "", "", "", "", edtavVradiotime_Visible, edtavVradiotime_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "����", bttBtnenter_Jsonclick, 5, "ȷ��", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_ProcedureUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "ȡ��", bttBtncancel_Jsonclick, 1, "ȡ��", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_ProcedureUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_procedure_br_procedureid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Procedure.gxTpr_Br_procedureid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Procedure.gxTpr_Br_procedureid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_procedure_br_procedureid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_procedure_br_procedureid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_procedure_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Procedure.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Procedure.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_procedure_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_procedure_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_procedure_br_information_patientno_Internalname, AV10BR_Procedure.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV10BR_Procedure.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_procedure_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_procedure_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_ProcedureUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_procedure_br_procedure_pxid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Procedure.gxTpr_Br_procedure_pxid), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Procedure.gxTpr_Br_procedure_pxid), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_procedure_br_procedure_pxid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_procedure_br_procedure_pxid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START8T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8T0( ) ;
      }

      protected void WS8T2( )
      {
         START8T2( ) ;
         EVT8T2( ) ;
      }

      protected void EVT8T2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E118T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E128T2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E138T2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E148T2 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE8T2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA8T2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavVpxsurgeryname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbavVpxsurgeryname.ItemCount > 0 )
         {
            AV11vPXSurgeryName = cmbavVpxsurgeryname.getValidValue(AV11vPXSurgeryName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vPXSurgeryName", AV11vPXSurgeryName);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavVpxsurgeryname.CurrentValue = StringUtil.RTrim( AV11vPXSurgeryName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxsurgeryname_Internalname, "Values", cmbavVpxsurgeryname.ToJavascriptSource(), true);
         }
         if ( cmbavVpxradiotherapy.ItemCount > 0 )
         {
            AV13vPXRadiotherapy = cmbavVpxradiotherapy.getValidValue(AV13vPXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vPXRadiotherapy", AV13vPXRadiotherapy);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavVpxradiotherapy.CurrentValue = StringUtil.RTrim( AV13vPXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxradiotherapy_Internalname, "Values", cmbavVpxradiotherapy.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF8T2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF8T2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E128T2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E148T2 ();
            WB8T0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes8T2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18BR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP8T0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E118T2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_procedure"), AV10BR_Procedure);
            /* Read variables values. */
            cmbavVpxsurgeryname.CurrentValue = cgiGet( cmbavVpxsurgeryname_Internalname);
            AV11vPXSurgeryName = cgiGet( cmbavVpxsurgeryname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vPXSurgeryName", AV11vPXSurgeryName);
            if ( context.localUtil.VCDate( cgiGet( edtavVdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"v Date"}), 1, "vVDATE");
               GX_FocusControl = edtavVdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12vDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vDate", context.localUtil.Format(AV12vDate, "9999/99/99"));
            }
            else
            {
               AV12vDate = context.localUtil.CToD( cgiGet( edtavVdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vDate", context.localUtil.Format(AV12vDate, "9999/99/99"));
            }
            cmbavVpxradiotherapy.CurrentValue = cgiGet( cmbavVpxradiotherapy_Internalname);
            AV13vPXRadiotherapy = cgiGet( cmbavVpxradiotherapy_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vPXRadiotherapy", AV13vPXRadiotherapy);
            if ( context.localUtil.VCDate( cgiGet( edtavVradiodate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"v Radio Date"}), 1, "vVRADIODATE");
               GX_FocusControl = edtavVradiodate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14vRadioDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vRadioDate", context.localUtil.Format(AV14vRadioDate, "9999/99/99"));
            }
            else
            {
               AV14vRadioDate = context.localUtil.CToD( cgiGet( edtavVradiodate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vRadioDate", context.localUtil.Format(AV14vRadioDate, "9999/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavVradiotime_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavVradiotime_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVRADIOTIME");
               GX_FocusControl = edtavVradiotime_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15vRadioTime = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vRadioTime", StringUtil.LTrim( StringUtil.Str( AV15vRadioTime, 15, 5)));
            }
            else
            {
               AV15vRadioTime = context.localUtil.CToN( cgiGet( edtavVradiotime_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vRadioTime", StringUtil.LTrim( StringUtil.Str( AV15vRadioTime, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_procedure_br_procedureid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_procedure_br_procedureid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PROCEDURE_BR_PROCEDUREID");
               GX_FocusControl = edtavBr_procedure_br_procedureid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Procedure.gxTpr_Br_procedureid = 0;
            }
            else
            {
               AV10BR_Procedure.gxTpr_Br_procedureid = (long)(context.localUtil.CToN( cgiGet( edtavBr_procedure_br_procedureid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_procedure_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_procedure_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PROCEDURE_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_procedure_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Procedure.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV10BR_Procedure.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_procedure_br_encounterid_Internalname), ".", ","));
            }
            AV10BR_Procedure.gxTpr_Br_information_patientno = cgiGet( edtavBr_procedure_br_information_patientno_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_procedure_br_procedure_pxid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_procedure_br_procedure_pxid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PROCEDURE_BR_PROCEDURE_PXID");
               GX_FocusControl = edtavBr_procedure_br_procedure_pxid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Procedure.gxTpr_Br_procedure_pxid = 0;
            }
            else
            {
               AV10BR_Procedure.gxTpr_Br_procedure_pxid = (long)(context.localUtil.CToN( cgiGet( edtavBr_procedure_br_procedure_pxid_Internalname), ".", ","));
            }
            /* Read saved values. */
            Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
            Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
            Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
            Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
            Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
            Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
            Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
            Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
            Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
            Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E118T2 ();
         if (returnInSub) return;
      }

      protected void E118T2( )
      {
         /* Start Routine */
         GXt_char1 = AV17tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV17tCurrentCode = GXt_char1;
         edtavBr_procedure_br_procedureid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_procedure_br_procedureid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_procedure_br_procedureid_Visible), 5, 0)), true);
         edtavBr_procedure_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_procedure_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_procedure_br_encounterid_Visible), 5, 0)), true);
         edtavBr_procedure_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_procedure_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_procedure_br_information_patientno_Visible), 5, 0)), true);
         edtavBr_procedure_br_procedure_pxid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_procedure_br_procedure_pxid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_procedure_br_procedure_pxid_Visible), 5, 0)), true);
         AV10BR_Procedure.Load(AV18BR_ProcedureID);
         AV12vDate = AV10BR_Procedure.gxTpr_Br_procedure_date;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vDate", context.localUtil.Format(AV12vDate, "9999/99/99"));
         AV14vRadioDate = AV10BR_Procedure.gxTpr_Br_procedure_radiodate;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vRadioDate", context.localUtil.Format(AV14vRadioDate, "9999/99/99"));
         AV15vRadioTime = AV10BR_Procedure.gxTpr_Br_procedure_radiotime;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vRadioTime", StringUtil.LTrim( StringUtil.Str( AV15vRadioTime, 15, 5)));
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV16CheckRequiredFieldsResult = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11vPXSurgeryName)) )
         {
            GX_msglist.addItem("�Ƿ������Ǳ�����д�ġ�");
            AV16CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13vPXRadiotherapy)) )
         {
            GX_msglist.addItem("�Ƿ���ܷ����Ǳ�����д�ġ�");
            AV16CheckRequiredFieldsResult = false;
         }
      }

      protected void S122( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV28GXV5 = 1;
         while ( AV28GXV5 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV28GXV5));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV28GXV5 = (int)(AV28GXV5+1);
         }
      }

      protected void E128T2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E138T2 ();
         if (returnInSub) return;
      }

      protected void E138T2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV21tCheckFlag) ;
         if ( ! AV21tCheckFlag )
         {
            if ( ( StringUtil.StrCmp(AV11vPXSurgeryName, "��") == 0 ) && ( StringUtil.StrCmp(AV13vPXRadiotherapy, "��") == 0 ) )
            {
               GX_msglist.addItem("�������ѡ���");
            }
            else
            {
               AV10BR_Procedure.gxTpr_Br_procedure_date = AV12vDate;
               AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery = AV11vPXSurgeryName;
               AV10BR_Procedure.gxTpr_Br_procedure_radiodate = AV14vRadioDate;
               AV10BR_Procedure.gxTpr_Br_procedure_radiotime = AV15vRadioTime;
               AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy = AV13vPXRadiotherapy;
               AV10BR_Procedure.Save();
               if ( AV10BR_Procedure.Success() )
               {
                  GXt_char1 = "";
                  new zutil_findtargetcode(context ).execute(  37,  AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery, out  GXt_char1) ;
                  AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery_code = GXt_char1;
                  GXt_char1 = "";
                  new zutil_findtargetcode(context ).execute(  37,  AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy, out  GXt_char1) ;
                  AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy_code = GXt_char1;
                  context.CommitDataStores("br_procedureupdate",pr_default);
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  AV19ErrorMsg = "";
                  AV30GXV7 = 1;
                  AV29GXV6 = AV10BR_Procedure.GetMessages();
                  while ( AV30GXV7 <= AV29GXV6.Count )
                  {
                     AV7Message = ((SdtMessages_Message)AV29GXV6.Item(AV30GXV7));
                     AV19ErrorMsg = AV19ErrorMsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                     AV30GXV7 = (int)(AV30GXV7+1);
                  }
                  GX_msglist.addItem(StringUtil.Trim( AV19ErrorMsg));
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Procedure", AV10BR_Procedure);
      }

      protected void nextLoad( )
      {
      }

      protected void E148T2( )
      {
         /* Load Routine */
         AV10BR_Procedure.Load(AV18BR_ProcedureID);
         if ( StringUtil.StrCmp(AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery, "��") == 0 )
         {
            edtavVdate_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdate_Visible), 5, 0)), true);
            cmbavVpxradiotherapy.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxradiotherapy_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavVpxradiotherapy.Visible), 5, 0)), true);
         }
         else
         {
            edtavVdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdate_Visible), 5, 0)), true);
            cmbavVpxradiotherapy.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxradiotherapy_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavVpxradiotherapy.Visible), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy, "��") == 0 )
         {
            edtavVradiodate_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVradiodate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVradiodate_Visible), 5, 0)), true);
            edtavVradiotime_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVradiotime_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVradiotime_Visible), 5, 0)), true);
            cmbavVpxsurgeryname.Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxsurgeryname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavVpxsurgeryname.Visible), 5, 0)), true);
         }
         else
         {
            edtavVradiodate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVradiodate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVradiodate_Visible), 5, 0)), true);
            edtavVradiotime_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVradiotime_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVradiotime_Visible), 5, 0)), true);
            cmbavVpxsurgeryname.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpxsurgeryname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavVpxsurgeryname.Visible), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery)) )
         {
            cmbavVpxsurgeryname.addItem(AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery, AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery, 0);
            AV11vPXSurgeryName = AV10BR_Procedure.gxTpr_Br_procedure_pxsurgery;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vPXSurgeryName", AV11vPXSurgeryName);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy)) )
         {
            cmbavVpxradiotherapy.addItem(AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy, AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy, 0);
            AV13vPXRadiotherapy = AV10BR_Procedure.gxTpr_Br_procedure_pxradiotherapy;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vPXRadiotherapy", AV13vPXRadiotherapy);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV18BR_ProcedureID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18BR_ProcedureID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA8T2( ) ;
         WS8T2( ) ;
         WE8T2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281516511", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.chs.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("br_procedureupdate.js", "?20202281516512", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbavVpxsurgeryname.Name = "vVPXSURGERYNAME";
         cmbavVpxsurgeryname.WebTags = "";
         cmbavVpxsurgeryname.addItem("��", "��", 0);
         cmbavVpxsurgeryname.addItem("��", "��", 0);
         cmbavVpxsurgeryname.addItem("����", "����", 0);
         if ( cmbavVpxsurgeryname.ItemCount > 0 )
         {
            AV11vPXSurgeryName = cmbavVpxsurgeryname.getValidValue(AV11vPXSurgeryName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vPXSurgeryName", AV11vPXSurgeryName);
         }
         cmbavVpxradiotherapy.Name = "vVPXRADIOTHERAPY";
         cmbavVpxradiotherapy.WebTags = "";
         cmbavVpxradiotherapy.addItem("��", "��", 0);
         cmbavVpxradiotherapy.addItem("��", "��", 0);
         cmbavVpxradiotherapy.addItem("����", "����", 0);
         if ( cmbavVpxradiotherapy.ItemCount > 0 )
         {
            AV13vPXRadiotherapy = cmbavVpxradiotherapy.getValidValue(AV13vPXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vPXRadiotherapy", AV13vPXRadiotherapy);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         cmbavVpxsurgeryname_Internalname = "vVPXSURGERYNAME";
         edtavVdate_Internalname = "vVDATE";
         cmbavVpxradiotherapy_Internalname = "vVPXRADIOTHERAPY";
         edtavVradiodate_Internalname = "vVRADIODATE";
         edtavVradiotime_Internalname = "vVRADIOTIME";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_procedure_br_procedureid_Internalname = "BR_PROCEDURE_BR_PROCEDUREID";
         edtavBr_procedure_br_encounterid_Internalname = "BR_PROCEDURE_BR_ENCOUNTERID";
         edtavBr_procedure_br_information_patientno_Internalname = "BR_PROCEDURE_BR_INFORMATION_PATIENTNO";
         edtavBr_procedure_br_procedure_pxid_Internalname = "BR_PROCEDURE_BR_PROCEDURE_PXID";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavBr_procedure_br_procedure_pxid_Jsonclick = "";
         edtavBr_procedure_br_procedure_pxid_Visible = 1;
         edtavBr_procedure_br_information_patientno_Jsonclick = "";
         edtavBr_procedure_br_information_patientno_Visible = 1;
         edtavBr_procedure_br_encounterid_Jsonclick = "";
         edtavBr_procedure_br_encounterid_Visible = 1;
         edtavBr_procedure_br_procedureid_Jsonclick = "";
         edtavBr_procedure_br_procedureid_Visible = 1;
         edtavVradiotime_Jsonclick = "";
         edtavVradiotime_Enabled = 1;
         edtavVradiotime_Visible = 1;
         edtavVradiodate_Jsonclick = "";
         edtavVradiodate_Enabled = 1;
         edtavVradiodate_Visible = 1;
         cmbavVpxradiotherapy_Jsonclick = "";
         cmbavVpxradiotherapy.Enabled = 1;
         cmbavVpxradiotherapy.Visible = 1;
         edtavVdate_Jsonclick = "";
         edtavVdate_Enabled = 1;
         edtavVdate_Visible = 1;
         cmbavVpxsurgeryname_Jsonclick = "";
         cmbavVpxsurgeryname.Enabled = 1;
         cmbavVpxsurgeryname.Visible = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "���ƴ���";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV18BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E138T2',iparms:[{av:'cmbavVpxsurgeryname'},{av:'AV11vPXSurgeryName',fld:'vVPXSURGERYNAME',pic:''},{av:'cmbavVpxradiotherapy'},{av:'AV13vPXRadiotherapy',fld:'vVPXRADIOTHERAPY',pic:''},{av:'AV12vDate',fld:'vVDATE',pic:''},{av:'AV10BR_Procedure',fld:'vBR_PROCEDURE',pic:''},{av:'AV14vRadioDate',fld:'vVRADIODATE',pic:''},{av:'AV15vRadioTime',fld:'vVRADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV10BR_Procedure',fld:'vBR_PROCEDURE',pic:''}]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_Procedure = new SdtBR_Procedure(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         AV11vPXSurgeryName = "";
         AV12vDate = DateTime.MinValue;
         AV13vPXRadiotherapy = "";
         AV14vRadioDate = DateTime.MinValue;
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17tCurrentCode = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GXt_char1 = "";
         AV19ErrorMsg = "";
         AV29GXV6 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_procedureupdate__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedureupdate__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavVdate_Visible ;
      private int edtavVdate_Enabled ;
      private int edtavVradiodate_Visible ;
      private int edtavVradiodate_Enabled ;
      private int edtavVradiotime_Visible ;
      private int edtavVradiotime_Enabled ;
      private int edtavBr_procedure_br_procedureid_Visible ;
      private int edtavBr_procedure_br_encounterid_Visible ;
      private int edtavBr_procedure_br_information_patientno_Visible ;
      private int edtavBr_procedure_br_procedure_pxid_Visible ;
      private int AV28GXV5 ;
      private int AV30GXV7 ;
      private int idxLst ;
      private long AV18BR_ProcedureID ;
      private long wcpOAV18BR_ProcedureID ;
      private decimal AV15vRadioTime ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String cmbavVpxsurgeryname_Internalname ;
      private String TempTags ;
      private String cmbavVpxsurgeryname_Jsonclick ;
      private String edtavVdate_Internalname ;
      private String edtavVdate_Jsonclick ;
      private String cmbavVpxradiotherapy_Internalname ;
      private String cmbavVpxradiotherapy_Jsonclick ;
      private String edtavVradiodate_Internalname ;
      private String edtavVradiodate_Jsonclick ;
      private String edtavVradiotime_Internalname ;
      private String edtavVradiotime_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_procedure_br_procedureid_Internalname ;
      private String edtavBr_procedure_br_procedureid_Jsonclick ;
      private String edtavBr_procedure_br_encounterid_Internalname ;
      private String edtavBr_procedure_br_encounterid_Jsonclick ;
      private String edtavBr_procedure_br_information_patientno_Internalname ;
      private String edtavBr_procedure_br_information_patientno_Jsonclick ;
      private String edtavBr_procedure_br_procedure_pxid_Internalname ;
      private String edtavBr_procedure_br_procedure_pxid_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXt_char1 ;
      private DateTime AV12vDate ;
      private DateTime AV14vRadioDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV16CheckRequiredFieldsResult ;
      private bool AV21tCheckFlag ;
      private String AV11vPXSurgeryName ;
      private String AV13vPXRadiotherapy ;
      private String AV17tCurrentCode ;
      private String AV19ErrorMsg ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavVpxsurgeryname ;
      private GXCombobox cmbavVpxradiotherapy ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV29GXV6 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Procedure AV10BR_Procedure ;
   }

   public class br_procedureupdate__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_procedureupdate__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        def= new CursorDef[] {
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
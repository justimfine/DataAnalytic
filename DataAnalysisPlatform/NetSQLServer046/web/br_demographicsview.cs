/*
               File: BR_DemographicsView
        Description: BR_Demographics View
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:59:6.34
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
   public class br_demographicsview : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_demographicsview( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_demographicsview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Demographics_ID ,
                           String aP1_TabCode )
      {
         this.AV10BR_Demographics_ID = aP0_BR_Demographics_ID;
         this.AV8TabCode = aP1_TabCode;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               AV10BR_Demographics_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_Demographics_ID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8TabCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
               }
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
         PA2O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271159636", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_demographicsview.aspx") + "?" + UrlEncode("" +AV10BR_Demographics_ID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode))+"\">") ;
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
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV12SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vBR_DEMOGRAPHICS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Demographics_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV8TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TABS_Class", StringUtil.RTrim( Tabs_Class));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABS_Historymanagement", StringUtil.BoolToStr( Tabs_Historymanagement));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            WebComp_Generalwc.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE2O2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2O2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_demographicsview.aspx") + "?" + UrlEncode("" +AV10BR_Demographics_ID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_DemographicsView" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Demographics View" ;
      }

      protected void WB2O0( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainViewWithShadow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWWLink", "Right", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblWorkwithlink_Internalname, "返回人口信息学", lblWorkwithlink_Link, "", lblWorkwithlink_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockLink", 0, "", 1, 1, 0, "HLP_BR_DemographicsView.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTabsPosition CellPaddingTop10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableviewcontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellTextBlockTitleWWP", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTxttabtitle_Internalname, lblTxttabtitle_Caption, "", "", lblTxttabtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleWWPTab", 0, "", 1, 1, 0, "HLP_BR_DemographicsView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTab", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTabs.SetProperty("PageCount", Tabs_Pagecount);
            ucTabs.SetProperty("Class", Tabs_Class);
            ucTabs.SetProperty("HistoryManagement", Tabs_Historymanagement);
            ucTabs.Render(context, "tab", Tabs_Internalname, "TABSContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_DemographicsView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablegeneral_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0026"+"", StringUtil.RTrim( WebComp_Generalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0026"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0026"+"");
                  }
                  WebComp_Generalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellPaddingBottom", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtabletabscontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_general_Internalname, divCell_general_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngeneral_Internalname, "", "General", bttBtngeneral_Jsonclick, 7, "General", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e112o1_client"+"'", TempTags, "", 2, "HLP_BR_DemographicsView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START2O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "BR_Demographics View", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2O0( ) ;
      }

      protected void WS2O2( )
      {
         START2O2( ) ;
         EVT2O2( ) ;
      }

      protected void EVT2O2( )
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
                              E122O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E132O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 26 )
                        {
                           OldGeneralwc = cgiGet( "W0026");
                           if ( ( StringUtil.Len( OldGeneralwc) == 0 ) || ( StringUtil.StrCmp(OldGeneralwc, WebComp_Generalwc_Component) != 0 ) )
                           {
                              WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", OldGeneralwc, new Object[] {context} );
                              WebComp_Generalwc.ComponentInit();
                              WebComp_Generalwc.Name = "OldGeneralwc";
                              WebComp_Generalwc_Component = OldGeneralwc;
                           }
                           if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                           {
                              WebComp_Generalwc.componentprocess("W0026", "", sEvt);
                           }
                           WebComp_Generalwc_Component = OldGeneralwc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE2O2( )
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

      protected void PA2O2( )
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2O2( ) ;
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

      protected void RF2O2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  WebComp_Generalwc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E132O2 ();
            WB2O0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes2O2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_DEMOGRAPHICS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Demographics_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP2O0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E122O2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            AV10BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( "vBR_DEMOGRAPHICS_ID"), ".", ","));
            AV11LoadAllTabs = StringUtil.StrToBool( cgiGet( "vLOADALLTABS"));
            AV12SelectedTabCode = cgiGet( "vSELECTEDTABCODE");
            Tabs_Class = cgiGet( "TABS_Class");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            Tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABS_Pagecount"), ".", ","));
            Tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "TABS_Historymanagement"));
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
         E122O2 ();
         if (returnInSub) return;
      }

      protected void E122O2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         lblWorkwithlink_Link = formatLink("br_demographicsww.aspx") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblWorkwithlink_Internalname, "Link", lblWorkwithlink_Link, true);
         AV16GXLvl11 = 0;
         /* Using cursor H002O2 */
         pr_default.execute(0, new Object[] {AV10BR_Demographics_ID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A61BR_Demographics_ID = H002O2_A61BR_Demographics_ID[0];
            AV16GXLvl11 = 1;
            Form.Caption = "人口信息学";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV16GXLvl11 == 0 )
         {
            Form.Caption = "记录未找到";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = false;
         }
         if ( AV9Exists )
         {
            AV12SelectedTabCode = AV8TabCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
            Tabs_Activepagecontrolname = AV12SelectedTabCode;
            ucTabs.SendProperty(context, "", false, Tabs_Internalname, "ActivePageControlName", Tabs_Activepagecontrolname);
            /* Execute user subroutine: 'LOADTABS' */
            S112 ();
            if (returnInSub) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E132O2( )
      {
         /* Load Routine */
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         divCell_general_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "BR_DemographicsGeneral")) != 0 )
            {
               WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "br_demographicsgeneral", new Object[] {context} );
               WebComp_Generalwc.ComponentInit();
               WebComp_Generalwc.Name = "BR_DemographicsGeneral";
               WebComp_Generalwc_Component = "BR_DemographicsGeneral";
            }
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.setjustcreated();
               WebComp_Generalwc.componentprepare(new Object[] {(String)"W0026",(String)"",(long)AV10BR_Demographics_ID});
               WebComp_Generalwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0026"+"");
               WebComp_Generalwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "General";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
            {
               divCell_general_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
            }
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10BR_Demographics_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_Demographics_ID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         AV8TabCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
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
         PA2O2( ) ;
         WS2O2( ) ;
         WE2O2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         if ( ! ( WebComp_Generalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271159673", true);
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
         context.AddJavascriptSource("br_demographicsview.js", "?20202271159673", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblWorkwithlink_Internalname = "WORKWITHLINK";
         lblTxttabtitle_Internalname = "TXTTABTITLE";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divUnnamedtablegeneral_Internalname = "UNNAMEDTABLEGENERAL";
         Tabs_Internalname = "TABS";
         bttBtngeneral_Internalname = "BTNGENERAL";
         divCell_general_Internalname = "CELL_GENERAL";
         divUnnamedtabletabscontainer_Internalname = "UNNAMEDTABLETABSCONTAINER";
         divUnnamedtableviewcontainer_Internalname = "UNNAMEDTABLEVIEWCONTAINER";
         divTablemain_Internalname = "TABLEMAIN";
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
         divCell_general_Visible = 1;
         lblTxttabtitle_Caption = "Title";
         lblWorkwithlink_Link = "";
         Tabs_Historymanagement = Convert.ToBoolean( -1);
         Tabs_Pagecount = 1;
         Tabs_Class = "ViewTab Tab";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "BR_Demographics View";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV10BR_Demographics_ID',fld:'vBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'GENERAL'","{handler:'E112O1',iparms:[{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_Demographics_ID',fld:'vBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'GENERAL'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'}]}");
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
         wcpOAV8TabCode = "";
         Tabs_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV12SelectedTabCode = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblWorkwithlink_Jsonclick = "";
         lblTxttabtitle_Jsonclick = "";
         ucTabs = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtngeneral_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         scmdbuf = "";
         H002O2_A61BR_Demographics_ID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_demographicsview__default(),
            new Object[][] {
                new Object[] {
               H002O2_A61BR_Demographics_ID
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV16GXLvl11 ;
      private short nGXWrapped ;
      private int Tabs_Pagecount ;
      private int divCell_general_Visible ;
      private int idxLst ;
      private long AV10BR_Demographics_ID ;
      private long wcpOAV10BR_Demographics_ID ;
      private long A61BR_Demographics_ID ;
      private String AV8TabCode ;
      private String wcpOAV8TabCode ;
      private String Tabs_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV12SelectedTabCode ;
      private String Tabs_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String lblWorkwithlink_Internalname ;
      private String lblWorkwithlink_Link ;
      private String lblWorkwithlink_Jsonclick ;
      private String divUnnamedtableviewcontainer_Internalname ;
      private String lblTxttabtitle_Internalname ;
      private String lblTxttabtitle_Caption ;
      private String lblTxttabtitle_Jsonclick ;
      private String Tabs_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divUnnamedtablegeneral_Internalname ;
      private String WebComp_Generalwc_Component ;
      private String OldGeneralwc ;
      private String divUnnamedtabletabscontainer_Internalname ;
      private String divCell_general_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtngeneral_Internalname ;
      private String bttBtngeneral_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV11LoadAllTabs ;
      private bool Tabs_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9Exists ;
      private GXWebComponent WebComp_Generalwc ;
      private GXUserControl ucTabs ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H002O2_A61BR_Demographics_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_demographicsview__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH002O2 ;
          prmH002O2 = new Object[] {
          new Object[] {"@AV10BR_Demographics_ID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002O2", "SELECT [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_Demographics_ID] = @AV10BR_Demographics_ID ORDER BY [BR_Demographics_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O2,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}

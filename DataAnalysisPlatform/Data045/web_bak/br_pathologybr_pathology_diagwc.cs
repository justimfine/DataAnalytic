/*
               File: BR_PathologyBR_Pathology_DiagWC
        Description: BR_Pathology BR_Pathology_Diag WC
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:5.67
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_pathologybr_pathology_diagwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologybr_pathology_diagwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public br_pathologybr_pathology_diagwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_PathologyID )
      {
         this.AV8BR_PathologyID = aP0_BR_PathologyID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV8BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_PathologyID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
               {
                  nRC_GXsfl_28 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_28_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  edtavDelete_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGrid_newrow( ) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  AV14OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV15OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV8BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = GetNextPar( );
                  AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = GetNextPar( );
                  AV45Pgmname = GetNextPar( );
                  edtavUpdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  edtavDelete_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  AV32IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
                  AV34IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV45Pgmname, AV32IsAuthorized_Update, AV34IsAuthorized_Delete, sPrefix) ;
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
                  return  ;
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA5F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV45Pgmname = "BR_PathologyBR_Pathology_DiagWC";
               context.Gx_err = 0;
               WS5F2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "BR_Pathology BR_Pathology_Diag WC") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?2020227938587", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologybr_pathology_diagwc.aspx") + "?" + UrlEncode("" +AV8BR_PathologyID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV15OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA", AV17BR_Pathology_Diag_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA", AV17BR_Pathology_Diag_LocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA", AV19BR_Pathology_Diag_OrganTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA", AV19BR_Pathology_Diag_OrganTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV45Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_UPDATE", AV32IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DELETE", AV34IsAuthorized_Delete);
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUPDATE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vDELETE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5F2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_pathologybr_pathology_diagwc.js", "?2020227938758", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BR_PathologyBR_Pathology_DiagWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Pathology BR_Pathology_Diag WC" ;
      }

      protected void WB5F0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_pathologybr_pathology_diagwc.aspx");
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
               context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
               context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablegridheader_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableheader.SetProperty("Width", Dvpanel_tableheader_Width);
            ucDvpanel_tableheader.SetProperty("AutoWidth", Dvpanel_tableheader_Autowidth);
            ucDvpanel_tableheader.SetProperty("AutoHeight", Dvpanel_tableheader_Autoheight);
            ucDvpanel_tableheader.SetProperty("Cls", Dvpanel_tableheader_Cls);
            ucDvpanel_tableheader.SetProperty("Title", Dvpanel_tableheader_Title);
            ucDvpanel_tableheader.SetProperty("Collapsible", Dvpanel_tableheader_Collapsible);
            ucDvpanel_tableheader.SetProperty("Collapsed", Dvpanel_tableheader_Collapsed);
            ucDvpanel_tableheader.SetProperty("ShowCollapseIcon", Dvpanel_tableheader_Showcollapseicon);
            ucDvpanel_tableheader.SetProperty("IconPosition", Dvpanel_tableheader_Iconposition);
            ucDvpanel_tableheader.SetProperty("AutoScroll", Dvpanel_tableheader_Autoscroll);
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, sPrefix+"DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, divTableheader_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'" + sPrefix + "',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyBR_Pathology_DiagWC.htm");
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
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"28\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "病理学诊断主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Diag_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_Loc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Diag_Organ_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_Organ_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_Organ_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV35Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV31Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV33Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A277BR_Pathology_Diag_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_Loc_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A278BR_Pathology_Diag_Organ);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_Organ_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_Organ_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 28 )
         {
            wbEnd = 0;
            nRC_GXsfl_28 = (short)(nGXsfl_28_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_gridpaginationbar_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucGridpaginationbar.SetProperty("Class", Gridpaginationbar_Class);
            ucGridpaginationbar.SetProperty("ShowFirst", Gridpaginationbar_Showfirst);
            ucGridpaginationbar.SetProperty("ShowPrevious", Gridpaginationbar_Showprevious);
            ucGridpaginationbar.SetProperty("ShowNext", Gridpaginationbar_Shownext);
            ucGridpaginationbar.SetProperty("ShowLast", Gridpaginationbar_Showlast);
            ucGridpaginationbar.SetProperty("PagesToShow", Gridpaginationbar_Pagestoshow);
            ucGridpaginationbar.SetProperty("PagingButtonsPosition", Gridpaginationbar_Pagingbuttonsposition);
            ucGridpaginationbar.SetProperty("PagingCaptionPosition", Gridpaginationbar_Pagingcaptionposition);
            ucGridpaginationbar.SetProperty("EmptyGridClass", Gridpaginationbar_Emptygridclass);
            ucGridpaginationbar.SetProperty("RowsPerPageSelector", Gridpaginationbar_Rowsperpageselector);
            ucGridpaginationbar.SetProperty("RowsPerPageOptions", Gridpaginationbar_Rowsperpageoptions);
            ucGridpaginationbar.SetProperty("Previous", Gridpaginationbar_Previous);
            ucGridpaginationbar.SetProperty("Next", Gridpaginationbar_Next);
            ucGridpaginationbar.SetProperty("Caption", Gridpaginationbar_Caption);
            ucGridpaginationbar.SetProperty("EmptyGridCaption", Gridpaginationbar_Emptygridcaption);
            ucGridpaginationbar.SetProperty("RowsPerPageCaption", Gridpaginationbar_Rowsperpagecaption);
            ucGridpaginationbar.SetProperty("CurrentPage", AV28GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV30GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV29GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, sPrefix+"GRIDPAGINATIONBARContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            /* User Defined Control */
            ucDdo_br_pathology_diag_loc.SetProperty("Caption", Ddo_br_pathology_diag_loc_Caption);
            ucDdo_br_pathology_diag_loc.SetProperty("Tooltip", Ddo_br_pathology_diag_loc_Tooltip);
            ucDdo_br_pathology_diag_loc.SetProperty("Cls", Ddo_br_pathology_diag_loc_Cls);
            ucDdo_br_pathology_diag_loc.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_loc_Dropdownoptionstype);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_loc_Includesortasc);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_loc_Includesortdsc);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeFilter", Ddo_br_pathology_diag_loc_Includefilter);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeDataList", Ddo_br_pathology_diag_loc_Includedatalist);
            ucDdo_br_pathology_diag_loc.SetProperty("SortASC", Ddo_br_pathology_diag_loc_Sortasc);
            ucDdo_br_pathology_diag_loc.SetProperty("SortDSC", Ddo_br_pathology_diag_loc_Sortdsc);
            ucDdo_br_pathology_diag_loc.SetProperty("SearchButtonText", Ddo_br_pathology_diag_loc_Searchbuttontext);
            ucDdo_br_pathology_diag_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_loc.SetProperty("DropDownOptionsData", AV17BR_Pathology_Diag_LocTitleFilterData);
            ucDdo_br_pathology_diag_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_loc_Internalname, sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyBR_Pathology_DiagWC.htm");
            /* User Defined Control */
            ucDdo_br_pathology_diag_organ.SetProperty("Caption", Ddo_br_pathology_diag_organ_Caption);
            ucDdo_br_pathology_diag_organ.SetProperty("Tooltip", Ddo_br_pathology_diag_organ_Tooltip);
            ucDdo_br_pathology_diag_organ.SetProperty("Cls", Ddo_br_pathology_diag_organ_Cls);
            ucDdo_br_pathology_diag_organ.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_organ_Dropdownoptionstype);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_organ_Includesortasc);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_organ_Includesortdsc);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeFilter", Ddo_br_pathology_diag_organ_Includefilter);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeDataList", Ddo_br_pathology_diag_organ_Includedatalist);
            ucDdo_br_pathology_diag_organ.SetProperty("SortASC", Ddo_br_pathology_diag_organ_Sortasc);
            ucDdo_br_pathology_diag_organ.SetProperty("SortDSC", Ddo_br_pathology_diag_organ_Sortdsc);
            ucDdo_br_pathology_diag_organ.SetProperty("SearchButtonText", Ddo_br_pathology_diag_organ_Searchbuttontext);
            ucDdo_br_pathology_diag_organ.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_organ.SetProperty("DropDownOptionsData", AV19BR_Pathology_Diag_OrganTitleFilterData);
            ucDdo_br_pathology_diag_organ.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_organ_Internalname, sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGANContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyBR_Pathology_DiagWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_PathologyBR_Pathology_DiagWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyBR_Pathology_DiagWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_PathologyBR_Pathology_DiagWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 28 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Pathology BR_Pathology_Diag WC", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP5F0( ) ;
            }
         }
      }

      protected void WS5F2( )
      {
         START5F2( ) ;
         EVT5F2( ) ;
      }

      protected void EVT5F2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E115F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E125F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E135F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E145F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E155F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5F0( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV35Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV35Display)) ? AV42Display_GXI : context.convertURL( context.PathToRelativeUrl( AV35Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV35Display), true);
                              AV31Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV31Update)) ? AV43Update_GXI : context.convertURL( context.PathToRelativeUrl( AV31Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV31Update), true);
                              AV33Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33Delete)) ? AV44Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV33Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV33Delete), true);
                              A276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_DiagID_Internalname), ".", ","));
                              A277BR_Pathology_Diag_Loc = cgiGet( edtBR_Pathology_Diag_Loc_Internalname);
                              n277BR_Pathology_Diag_Loc = false;
                              A278BR_Pathology_Diag_Organ = cgiGet( edtBR_Pathology_Diag_Organ_Internalname);
                              n278BR_Pathology_Diag_Organ = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E165F2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E175F2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E185F2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP5F0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE5F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5F2( ) ;
            }
         }
      }

      protected void PA5F2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_282( ) ;
         while ( nGXsfl_28_idx <= nRC_GXsfl_28 )
         {
            sendrow_282( ) ;
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       long AV8BR_PathologyID ,
                                       String AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace ,
                                       String AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace ,
                                       String AV45Pgmname ,
                                       bool AV32IsAuthorized_Update ,
                                       bool AV34IsAuthorized_Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5F2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_PATHOLOGY_DIAGID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_PATHOLOGY_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")));
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
         RF5F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV45Pgmname = "BR_PathologyBR_Pathology_DiagWC";
         context.Gx_err = 0;
      }

      protected void RF5F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E175F2 ();
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         bGXsfl_28_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_282( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A226BR_PathologyID ,
                                                 AV8BR_PathologyID } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H005F2 */
            pr_default.execute(0, new Object[] {AV8BR_PathologyID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A226BR_PathologyID = H005F2_A226BR_PathologyID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               n226BR_PathologyID = H005F2_n226BR_PathologyID[0];
               A278BR_Pathology_Diag_Organ = H005F2_A278BR_Pathology_Diag_Organ[0];
               n278BR_Pathology_Diag_Organ = H005F2_n278BR_Pathology_Diag_Organ[0];
               A277BR_Pathology_Diag_Loc = H005F2_A277BR_Pathology_Diag_Loc[0];
               n277BR_Pathology_Diag_Loc = H005F2_n277BR_Pathology_Diag_Loc[0];
               A276BR_Pathology_DiagID = H005F2_A276BR_Pathology_DiagID[0];
               E185F2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB5F0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5F2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_PATHOLOGY_DIAGID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A226BR_PathologyID ,
                                              AV8BR_PathologyID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H005F3 */
         pr_default.execute(1, new Object[] {AV8BR_PathologyID});
         GRID_nRecordCount = H005F3_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV45Pgmname, AV32IsAuthorized_Update, AV34IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV45Pgmname, AV32IsAuthorized_Update, AV34IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV45Pgmname, AV32IsAuthorized_Update, AV34IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV45Pgmname, AV32IsAuthorized_Update, AV34IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV45Pgmname, AV32IsAuthorized_Update, AV34IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5F0( )
      {
         /* Before Start, stand alone formulas. */
         AV45Pgmname = "BR_PathologyBR_Pathology_DiagWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E165F2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV25DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA"), AV17BR_Pathology_Diag_LocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA"), AV19BR_Pathology_Diag_OrganTitleFilterData);
            /* Read variables values. */
            AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace", AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace);
            AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace", AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace);
            A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            else
            {
               AV14OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            AV15OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_28"), ".", ","));
            AV28GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV30GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV29GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_PathologyID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_pathology_diag_loc_Caption = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Caption");
            Ddo_br_pathology_diag_loc_Tooltip = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Tooltip");
            Ddo_br_pathology_diag_loc_Cls = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Cls");
            Ddo_br_pathology_diag_loc_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Dropdownoptionstype");
            Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_loc_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includesortasc"));
            Ddo_br_pathology_diag_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includesortdsc"));
            Ddo_br_pathology_diag_loc_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Sortedstatus");
            Ddo_br_pathology_diag_loc_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includefilter"));
            Ddo_br_pathology_diag_loc_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Includedatalist"));
            Ddo_br_pathology_diag_loc_Sortasc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Sortasc");
            Ddo_br_pathology_diag_loc_Sortdsc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Sortdsc");
            Ddo_br_pathology_diag_loc_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Searchbuttontext");
            Ddo_br_pathology_diag_organ_Caption = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Caption");
            Ddo_br_pathology_diag_organ_Tooltip = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Tooltip");
            Ddo_br_pathology_diag_organ_Cls = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Cls");
            Ddo_br_pathology_diag_organ_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Dropdownoptionstype");
            Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_organ_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortasc"));
            Ddo_br_pathology_diag_organ_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortdsc"));
            Ddo_br_pathology_diag_organ_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortedstatus");
            Ddo_br_pathology_diag_organ_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includefilter"));
            Ddo_br_pathology_diag_organ_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Includedatalist"));
            Ddo_br_pathology_diag_organ_Sortasc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortasc");
            Ddo_br_pathology_diag_organ_Sortdsc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortdsc");
            Ddo_br_pathology_diag_organ_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_diag_loc_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC_Activeeventkey");
            Ddo_br_pathology_diag_organ_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E165F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E165F2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_Loc";
         ucDdo_br_pathology_diag_loc.SendProperty(context, sPrefix, false, Ddo_br_pathology_diag_loc_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace);
         AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace", AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_Organ";
         ucDdo_br_pathology_diag_organ.SendProperty(context, sPrefix, false, Ddo_br_pathology_diag_organ_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace);
         AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace", AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV14OrderedBy < 1 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV25DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV25DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV38tEncounterType = StringUtil.Trim( AV39WebSession.Get("Br_EncounterType"));
         if ( StringUtil.StrCmp(AV38tEncounterType, "check") == 0 )
         {
            divTableheader_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTableheader_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableheader_Visible), 5, 0)), true);
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
      }

      protected void E175F2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_Pathology_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Pathology_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_Pathology_Diag_Loc_Titleformat = 2;
         edtBR_Pathology_Diag_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理诊断(部位)", AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_Diag_Loc_Internalname, "Title", edtBR_Pathology_Diag_Loc_Title, !bGXsfl_28_Refreshing);
         edtBR_Pathology_Diag_Organ_Titleformat = 2;
         edtBR_Pathology_Diag_Organ_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理诊断(器官)", AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_Diag_Organ_Internalname, "Title", edtBR_Pathology_Diag_Organ_Title, !bGXsfl_28_Refreshing);
         AV28GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridCurrentPage), 10, 0)));
         AV29GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridPageSize), 10, 0)));
         AV30GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Diag_LocTitleFilterData", AV17BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Diag_OrganTitleFilterData", AV19BR_Pathology_Diag_OrganTitleFilterData);
      }

      protected void E115F2( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
         {
            subgrid_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
         {
            subgrid_nextpage( ) ;
         }
         else
         {
            AV27PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV27PageToGo) ;
         }
      }

      protected void E125F2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135F2( )
      {
         /* Ddo_br_pathology_diag_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_loc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_diag_loc_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_loc.SendProperty(context, sPrefix, false, Ddo_br_pathology_diag_loc_Internalname, "SortedStatus", Ddo_br_pathology_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_diag_loc_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_loc.SendProperty(context, sPrefix, false, Ddo_br_pathology_diag_loc_Internalname, "SortedStatus", Ddo_br_pathology_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Diag_LocTitleFilterData", AV17BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Diag_OrganTitleFilterData", AV19BR_Pathology_Diag_OrganTitleFilterData);
      }

      protected void E145F2( )
      {
         /* Ddo_br_pathology_diag_organ_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_organ_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_diag_organ_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_organ.SendProperty(context, sPrefix, false, Ddo_br_pathology_diag_organ_Internalname, "SortedStatus", Ddo_br_pathology_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_organ_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_diag_organ_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_organ.SendProperty(context, sPrefix, false, Ddo_br_pathology_diag_organ_Internalname, "SortedStatus", Ddo_br_pathology_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Diag_LocTitleFilterData", AV17BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Diag_OrganTitleFilterData", AV19BR_Pathology_Diag_OrganTitleFilterData);
      }

      private void E185F2( )
      {
         /* Grid_Load Routine */
         AV35Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV35Display);
         AV42Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_pathology_diagview.aspx") + "?" + UrlEncode("" +A276BR_Pathology_DiagID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV31Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavUpdate_Internalname, AV31Update);
         AV43Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV32IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A276BR_Pathology_DiagID);
         }
         AV33Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDelete_Internalname, AV33Delete);
         AV44Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV34IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A276BR_Pathology_DiagID);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 28;
         }
         sendrow_282( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_28_Refreshing )
         {
            context.DoAjaxLoad(28, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E155F2( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_pathology_diaginsert.aspx") + "?" + UrlEncode("" +AV8BR_PathologyID));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV32IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean2) ;
         AV32IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV32IsAuthorized_Update", AV32IsAuthorized_Update);
         if ( ! ( AV32IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV34IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean2) ;
         AV34IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV34IsAuthorized_Delete", AV34IsAuthorized_Delete);
         if ( ! ( AV34IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV37TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean2) ;
         AV37TempBoolean = GXt_boolean2;
         if ( ! ( AV37TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV45Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV45Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV45Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV14OrderedBy = AV12GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         AV15OrderedDsc = AV12GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV12GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV12GridState.FromXml(AV16Session.Get(AV45Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV45Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV45Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Pathology_Diag";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_PathologyID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_PathologyID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
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
         PA5F2( ) ;
         WS5F2( ) ;
         WE5F2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV8BR_PathologyID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5F2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_pathologybr_pathology_diagwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5F2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_PathologyID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
         }
         wcpOAV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_PathologyID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_PathologyID != wcpOAV8BR_PathologyID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_PathologyID = AV8BR_PathologyID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_PathologyID = cgiGet( sPrefix+"AV8BR_PathologyID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_PathologyID) > 0 )
         {
            AV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_PathologyID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
         }
         else
         {
            AV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_PathologyID_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA5F2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS5F2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_PathologyID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_PathologyID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_PathologyID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_PathologyID_CTRL", StringUtil.RTrim( sCtrlAV8BR_PathologyID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE5F2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("DVelop/DVPaginationBar/DVPaginationBar.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/fontawesome/font-awesome.min.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279381519", true);
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
         context.AddJavascriptSource("br_pathologybr_pathology_diagwc.js", "?20202279381519", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_idx;
         edtBR_Pathology_DiagID_Internalname = sPrefix+"BR_PATHOLOGY_DIAGID_"+sGXsfl_28_idx;
         edtBR_Pathology_Diag_Loc_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_LOC_"+sGXsfl_28_idx;
         edtBR_Pathology_Diag_Organ_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_ORGAN_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_DiagID_Internalname = sPrefix+"BR_PATHOLOGY_DIAGID_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_Diag_Loc_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_LOC_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_Diag_Organ_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_ORGAN_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB5F0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_28_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)(((nGXsfl_28_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_28_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV35Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV35Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV42Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV35Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV35Display)) ? AV42Display_GXI : context.PathToRelativeUrl( AV35Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV35Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV31Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV31Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV43Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV31Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV31Update)) ? AV43Update_GXI : context.PathToRelativeUrl( AV31Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavUpdate_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e195f2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV31Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV33Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV33Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV33Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV33Delete)) ? AV44Delete_GXI : context.PathToRelativeUrl( AV33Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDelete_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e205f2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV33Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_DiagID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_DiagID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_Loc_Internalname,(String)A277BR_Pathology_Diag_Loc,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_Organ_Internalname,(String)A278BR_Pathology_Diag_Organ,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_Organ_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5F2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         divTableactions_Internalname = sPrefix+"TABLEACTIONS";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtavUpdate_Internalname = sPrefix+"vUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         edtBR_Pathology_DiagID_Internalname = sPrefix+"BR_PATHOLOGY_DIAGID";
         edtBR_Pathology_Diag_Loc_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_LOC";
         edtBR_Pathology_Diag_Organ_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_ORGAN";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_pathology_diag_loc_Internalname = sPrefix+"DDO_BR_PATHOLOGY_DIAG_LOC";
         edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_diag_organ_Internalname = sPrefix+"DDO_BR_PATHOLOGY_DIAG_ORGAN";
         edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE";
         edtBR_PathologyID_Internalname = sPrefix+"BR_PATHOLOGYID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtBR_Pathology_Diag_Organ_Jsonclick = "";
         edtBR_Pathology_Diag_Loc_Jsonclick = "";
         edtBR_Pathology_DiagID_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavDelete_Enabled = 1;
         edtavUpdate_Jsonclick = "";
         edtavUpdate_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Visible = 1;
         edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_Diag_Organ_Titleformat = 0;
         edtBR_Pathology_Diag_Organ_Title = "病理诊断(器官)";
         edtBR_Pathology_Diag_Loc_Titleformat = 0;
         edtBR_Pathology_Diag_Loc_Title = "病理诊断(部位)";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         divTableheader_Visible = 1;
         Ddo_br_pathology_diag_organ_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_organ_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_organ_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_organ_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_organ_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_organ_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_organ_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_organ_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_organ_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_organ_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_organ_Caption = "";
         Ddo_br_pathology_diag_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_loc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_loc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_loc_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_loc_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridpaginationbar_Rowsperpageselectedvalue = 10;
         Gridpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridpaginationbar_Pagingcaptionposition = "Left";
         Gridpaginationbar_Pagingbuttonsposition = "Right";
         Gridpaginationbar_Pagestoshow = 5;
         Gridpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridpaginationbar_Caption = "<CURRENT_PAGE>页/<TOTAL_PAGES>页 记录：<TOTAL_RECORDS>条";
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Class = "PaginationBar";
         Dvpanel_tableheader_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Iconposition = "left";
         Dvpanel_tableheader_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Title = "选项";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         subGrid_Rows = 0;
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV45Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED","{handler:'E135F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_pathology_diag_loc_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'AV17BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED","{handler:'E145F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_pathology_diag_organ_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'AV17BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E185F2',iparms:[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV32IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV34IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV35Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV31Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV33Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E155F2',iparms:[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VUPDATE.CLICK","{handler:'E195F2',iparms:[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VUPDATE.CLICK",",oparms:[]}");
         setEventMetadata("VDELETE.CLICK","{handler:'E205F2',iparms:[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VDELETE.CLICK",",oparms:[]}");
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
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_pathology_diag_loc_Activeeventkey = "";
         Ddo_br_pathology_diag_organ_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = "";
         AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = "";
         AV45Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV25DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_Pathology_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Pathology_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_diag_loc_Sortedstatus = "";
         Ddo_br_pathology_diag_organ_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV35Display = "";
         AV31Update = "";
         AV33Delete = "";
         A277BR_Pathology_Diag_Loc = "";
         A278BR_Pathology_Diag_Organ = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_diag_loc = new GXUserControl();
         ucDdo_br_pathology_diag_organ = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV42Display_GXI = "";
         AV43Update_GXI = "";
         AV44Delete_GXI = "";
         scmdbuf = "";
         H005F2_A226BR_PathologyID = new long[1] ;
         H005F2_n226BR_PathologyID = new bool[] {false} ;
         H005F2_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         H005F2_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         H005F2_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         H005F2_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         H005F2_A276BR_Pathology_DiagID = new long[1] ;
         H005F3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV38tEncounterType = "";
         AV39WebSession = context.GetSession();
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_PathologyID = "";
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologybr_pathology_diagwc__default(),
            new Object[][] {
                new Object[] {
               H005F2_A226BR_PathologyID, H005F2_n226BR_PathologyID, H005F2_A278BR_Pathology_Diag_Organ, H005F2_n278BR_Pathology_Diag_Organ, H005F2_A277BR_Pathology_Diag_Loc, H005F2_n277BR_Pathology_Diag_Loc, H005F2_A276BR_Pathology_DiagID
               }
               , new Object[] {
               H005F3_AGRID_nRecordCount
               }
            }
         );
         AV45Pgmname = "BR_PathologyBR_Pathology_DiagWC";
         /* GeneXus formulas. */
         AV45Pgmname = "BR_PathologyBR_Pathology_DiagWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV14OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Pathology_Diag_Loc_Titleformat ;
      private short edtBR_Pathology_Diag_Organ_Titleformat ;
      private short subGrid_Sortable ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int divTableheader_Visible ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible ;
      private int edtBR_PathologyID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV27PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private long AV8BR_PathologyID ;
      private long wcpOAV8BR_PathologyID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV28GridCurrentPage ;
      private long AV30GridRecordCount ;
      private long AV29GridPageSize ;
      private long A276BR_Pathology_DiagID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_diag_loc_Activeeventkey ;
      private String Ddo_br_pathology_diag_organ_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String AV45Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Gridpaginationbar_Class ;
      private String Gridpaginationbar_Previous ;
      private String Gridpaginationbar_Next ;
      private String Gridpaginationbar_Caption ;
      private String Gridpaginationbar_Pagingbuttonsposition ;
      private String Gridpaginationbar_Pagingcaptionposition ;
      private String Gridpaginationbar_Emptygridclass ;
      private String Gridpaginationbar_Rowsperpageoptions ;
      private String Gridpaginationbar_Emptygridcaption ;
      private String Gridpaginationbar_Rowsperpagecaption ;
      private String Ddo_br_pathology_diag_loc_Caption ;
      private String Ddo_br_pathology_diag_loc_Tooltip ;
      private String Ddo_br_pathology_diag_loc_Cls ;
      private String Ddo_br_pathology_diag_loc_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_loc_Sortedstatus ;
      private String Ddo_br_pathology_diag_loc_Sortasc ;
      private String Ddo_br_pathology_diag_loc_Sortdsc ;
      private String Ddo_br_pathology_diag_loc_Searchbuttontext ;
      private String Ddo_br_pathology_diag_organ_Caption ;
      private String Ddo_br_pathology_diag_organ_Tooltip ;
      private String Ddo_br_pathology_diag_organ_Cls ;
      private String Ddo_br_pathology_diag_organ_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_organ_Sortedstatus ;
      private String Ddo_br_pathology_diag_organ_Sortasc ;
      private String Ddo_br_pathology_diag_organ_Sortdsc ;
      private String Ddo_br_pathology_diag_organ_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Pathology_Diag_Loc_Title ;
      private String edtBR_Pathology_Diag_Organ_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_diag_loc_Internalname ;
      private String edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_diag_organ_Internalname ;
      private String edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtBR_Pathology_DiagID_Internalname ;
      private String edtBR_Pathology_Diag_Loc_Internalname ;
      private String edtBR_Pathology_Diag_Organ_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_PathologyID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Pathology_DiagID_Jsonclick ;
      private String edtBR_Pathology_Diag_Loc_Jsonclick ;
      private String edtBR_Pathology_Diag_Organ_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool AV15OrderedDsc ;
      private bool AV32IsAuthorized_Update ;
      private bool AV34IsAuthorized_Delete ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_pathology_diag_loc_Includesortasc ;
      private bool Ddo_br_pathology_diag_loc_Includesortdsc ;
      private bool Ddo_br_pathology_diag_loc_Includefilter ;
      private bool Ddo_br_pathology_diag_loc_Includedatalist ;
      private bool Ddo_br_pathology_diag_organ_Includesortasc ;
      private bool Ddo_br_pathology_diag_organ_Includesortdsc ;
      private bool Ddo_br_pathology_diag_organ_Includefilter ;
      private bool Ddo_br_pathology_diag_organ_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n277BR_Pathology_Diag_Loc ;
      private bool n278BR_Pathology_Diag_Organ ;
      private bool gxdyncontrolsrefreshing ;
      private bool n226BR_PathologyID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV37TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV35Display_IsBlob ;
      private bool AV31Update_IsBlob ;
      private bool AV33Delete_IsBlob ;
      private String AV18ddo_BR_Pathology_Diag_LocTitleControlIdToReplace ;
      private String AV20ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace ;
      private String A277BR_Pathology_Diag_Loc ;
      private String A278BR_Pathology_Diag_Organ ;
      private String AV42Display_GXI ;
      private String AV43Update_GXI ;
      private String AV44Delete_GXI ;
      private String AV38tEncounterType ;
      private String AV35Display ;
      private String AV31Update ;
      private String AV33Delete ;
      private IGxSession AV39WebSession ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathology_diag_loc ;
      private GXUserControl ucDdo_br_pathology_diag_organ ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005F2_A226BR_PathologyID ;
      private bool[] H005F2_n226BR_PathologyID ;
      private String[] H005F2_A278BR_Pathology_Diag_Organ ;
      private bool[] H005F2_n278BR_Pathology_Diag_Organ ;
      private String[] H005F2_A277BR_Pathology_Diag_Loc ;
      private bool[] H005F2_n277BR_Pathology_Diag_Loc ;
      private long[] H005F2_A276BR_Pathology_DiagID ;
      private long[] H005F3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Pathology_Diag_LocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Pathology_Diag_OrganTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV25DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_pathologybr_pathology_diagwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005F2( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A226BR_PathologyID ,
                                             long AV8BR_PathologyID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [4] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_PathologyID], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_Loc], [BR_Pathology_DiagID]";
         sFromString = " FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_PathologyID] = @AV8BR_PathologyID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_DiagID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_DiagID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID], [BR_Pathology_Diag_Organ]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC, [BR_Pathology_Diag_Organ] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_DiagID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005F3( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A226BR_PathologyID ,
                                             long AV8BR_PathologyID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_PathologyID] = @AV8BR_PathologyID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H005F2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
               case 1 :
                     return conditional_H005F3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH005F2 ;
          prmH005F2 = new Object[] {
          new Object[] {"@AV8BR_PathologyID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005F3 ;
          prmH005F3 = new Object[] {
          new Object[] {"@AV8BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005F2,11,0,true,false )
             ,new CursorDef("H005F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005F3,1,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[1]);
                }
                return;
       }
    }

 }

}

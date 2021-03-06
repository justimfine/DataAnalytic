/*
               File: BR_SchemePrompt
        Description: 选择化疗方案
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:15:15.38
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
   public class br_schemeprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_schemeprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_schemeprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_SchemeID ,
                           ref String aP1_InOutBR_Scheme_Chem_Regimens )
      {
         this.AV8InOutBR_SchemeID = aP0_InOutBR_SchemeID;
         this.AV9InOutBR_Scheme_Chem_Regimens = aP1_InOutBR_Scheme_Chem_Regimens;
         executePrivate();
         aP0_InOutBR_SchemeID=this.AV8InOutBR_SchemeID;
         aP1_InOutBR_Scheme_Chem_Regimens=this.AV9InOutBR_Scheme_Chem_Regimens;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_12_idx = GetNextPar( );
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
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV14ddo_BR_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_SchemeIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV8InOutBR_SchemeID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_SchemeID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_Scheme_Chem_Regimens = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Scheme_Chem_Regimens", AV9InOutBR_Scheme_Chem_Regimens);
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
            ValidateSpaRequest();
            PA6F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV33Pgmname = "BR_SchemePrompt";
               context.Gx_err = 0;
               WS6F2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE6F2( ) ;
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022815151550", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_schemeprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_SchemeID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_Scheme_Chem_Regimens))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEMEIDTITLEFILTERDATA", AV13BR_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEMEIDTITLEFILTERDATA", AV13BR_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV15BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV15BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_THERAPY_LINETITLEFILTERDATA", AV19BR_Scheme_Therapy_LineTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_THERAPY_LINETITLEFILTERDATA", AV19BR_Scheme_Therapy_LineTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA", AV21BR_Scheme_Chem_CycleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA", AV21BR_Scheme_Chem_CycleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA", AV23BR_Scheme_Chem_DetailTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA", AV23BR_Scheme_Chem_DetailTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_SCHEME_CHEM_REGIMENS", AV9InOutBR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Caption", StringUtil.RTrim( Ddo_br_schemeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Tooltip", StringUtil.RTrim( Ddo_br_schemeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Cls", StringUtil.RTrim( Ddo_br_schemeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_schemeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_schemeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortedstatus", StringUtil.RTrim( Ddo_br_schemeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includefilter", StringUtil.BoolToStr( Ddo_br_schemeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_schemeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortasc", StringUtil.RTrim( Ddo_br_schemeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortdsc", StringUtil.RTrim( Ddo_br_schemeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_schemeid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Caption", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Tooltip", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Cls", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Sortasc", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Activeeventkey));
      }

      protected void RenderHtmlCloseForm6F2( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "BR_SchemePrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择化疗方案" ;
      }

      protected void WB6F0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", divTablemain_Height, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WorkWithCell", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"12\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_SchemeID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_SchemeID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_SchemeID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Regimens_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Regimens_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Regimens_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Therapy_Line_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Therapy_Line_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Therapy_Line_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Cycle_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Cycle_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Cycle_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Detail_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Detail_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Detail_Title) ;
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
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV30Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_SchemeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_SchemeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A328BR_Scheme_Chem_Regimens);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Regimens_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Regimens_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A329BR_Scheme_Therapy_Line);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Therapy_Line_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Therapy_Line_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A330BR_Scheme_Chem_Cycle, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Cycle_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Cycle_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A331BR_Scheme_Chem_Detail);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Detail_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Detail_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 12 )
         {
            wbEnd = 0;
            nRC_GXsfl_12 = (short)(nGXsfl_12_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV27GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV29GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV28GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
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
            ucDdo_br_schemeid.SetProperty("Caption", Ddo_br_schemeid_Caption);
            ucDdo_br_schemeid.SetProperty("Tooltip", Ddo_br_schemeid_Tooltip);
            ucDdo_br_schemeid.SetProperty("Cls", Ddo_br_schemeid_Cls);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsType", Ddo_br_schemeid_Dropdownoptionstype);
            ucDdo_br_schemeid.SetProperty("IncludeSortASC", Ddo_br_schemeid_Includesortasc);
            ucDdo_br_schemeid.SetProperty("IncludeSortDSC", Ddo_br_schemeid_Includesortdsc);
            ucDdo_br_schemeid.SetProperty("IncludeFilter", Ddo_br_schemeid_Includefilter);
            ucDdo_br_schemeid.SetProperty("IncludeDataList", Ddo_br_schemeid_Includedatalist);
            ucDdo_br_schemeid.SetProperty("SortASC", Ddo_br_schemeid_Sortasc);
            ucDdo_br_schemeid.SetProperty("SortDSC", Ddo_br_schemeid_Sortdsc);
            ucDdo_br_schemeid.SetProperty("SearchButtonText", Ddo_br_schemeid_Searchbuttontext);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsData", AV13BR_SchemeIDTitleFilterData);
            ucDdo_br_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_schemeid_Internalname, "DDO_BR_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV15BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_regimens.SetProperty("Caption", Ddo_br_scheme_chem_regimens_Caption);
            ucDdo_br_scheme_chem_regimens.SetProperty("Tooltip", Ddo_br_scheme_chem_regimens_Tooltip);
            ucDdo_br_scheme_chem_regimens.SetProperty("Cls", Ddo_br_scheme_chem_regimens_Cls);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_regimens_Dropdownoptionstype);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_regimens_Includesortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_regimens_Includesortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeFilter", Ddo_br_scheme_chem_regimens_Includefilter);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeDataList", Ddo_br_scheme_chem_regimens_Includedatalist);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortASC", Ddo_br_scheme_chem_regimens_Sortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortDSC", Ddo_br_scheme_chem_regimens_Sortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("SearchButtonText", Ddo_br_scheme_chem_regimens_Searchbuttontext);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
            ucDdo_br_scheme_chem_regimens.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_regimens_Internalname, "DDO_BR_SCHEME_CHEM_REGIMENSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_scheme_therapy_line.SetProperty("Caption", Ddo_br_scheme_therapy_line_Caption);
            ucDdo_br_scheme_therapy_line.SetProperty("Tooltip", Ddo_br_scheme_therapy_line_Tooltip);
            ucDdo_br_scheme_therapy_line.SetProperty("Cls", Ddo_br_scheme_therapy_line_Cls);
            ucDdo_br_scheme_therapy_line.SetProperty("DropDownOptionsType", Ddo_br_scheme_therapy_line_Dropdownoptionstype);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeSortASC", Ddo_br_scheme_therapy_line_Includesortasc);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeSortDSC", Ddo_br_scheme_therapy_line_Includesortdsc);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeFilter", Ddo_br_scheme_therapy_line_Includefilter);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeDataList", Ddo_br_scheme_therapy_line_Includedatalist);
            ucDdo_br_scheme_therapy_line.SetProperty("SortASC", Ddo_br_scheme_therapy_line_Sortasc);
            ucDdo_br_scheme_therapy_line.SetProperty("SortDSC", Ddo_br_scheme_therapy_line_Sortdsc);
            ucDdo_br_scheme_therapy_line.SetProperty("SearchButtonText", Ddo_br_scheme_therapy_line_Searchbuttontext);
            ucDdo_br_scheme_therapy_line.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_scheme_therapy_line.SetProperty("DropDownOptionsData", AV19BR_Scheme_Therapy_LineTitleFilterData);
            ucDdo_br_scheme_therapy_line.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_therapy_line_Internalname, "DDO_BR_SCHEME_THERAPY_LINEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_cycle.SetProperty("Caption", Ddo_br_scheme_chem_cycle_Caption);
            ucDdo_br_scheme_chem_cycle.SetProperty("Tooltip", Ddo_br_scheme_chem_cycle_Tooltip);
            ucDdo_br_scheme_chem_cycle.SetProperty("Cls", Ddo_br_scheme_chem_cycle_Cls);
            ucDdo_br_scheme_chem_cycle.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_cycle_Dropdownoptionstype);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_cycle_Includesortasc);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_cycle_Includesortdsc);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeFilter", Ddo_br_scheme_chem_cycle_Includefilter);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeDataList", Ddo_br_scheme_chem_cycle_Includedatalist);
            ucDdo_br_scheme_chem_cycle.SetProperty("SortASC", Ddo_br_scheme_chem_cycle_Sortasc);
            ucDdo_br_scheme_chem_cycle.SetProperty("SortDSC", Ddo_br_scheme_chem_cycle_Sortdsc);
            ucDdo_br_scheme_chem_cycle.SetProperty("SearchButtonText", Ddo_br_scheme_chem_cycle_Searchbuttontext);
            ucDdo_br_scheme_chem_cycle.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_cycle.SetProperty("DropDownOptionsData", AV21BR_Scheme_Chem_CycleTitleFilterData);
            ucDdo_br_scheme_chem_cycle.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_cycle_Internalname, "DDO_BR_SCHEME_CHEM_CYCLEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_detail.SetProperty("Caption", Ddo_br_scheme_chem_detail_Caption);
            ucDdo_br_scheme_chem_detail.SetProperty("Tooltip", Ddo_br_scheme_chem_detail_Tooltip);
            ucDdo_br_scheme_chem_detail.SetProperty("Cls", Ddo_br_scheme_chem_detail_Cls);
            ucDdo_br_scheme_chem_detail.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_detail_Dropdownoptionstype);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_detail_Includesortasc);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_detail_Includesortdsc);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeFilter", Ddo_br_scheme_chem_detail_Includefilter);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeDataList", Ddo_br_scheme_chem_detail_Includedatalist);
            ucDdo_br_scheme_chem_detail.SetProperty("SortASC", Ddo_br_scheme_chem_detail_Sortasc);
            ucDdo_br_scheme_chem_detail.SetProperty("SortDSC", Ddo_br_scheme_chem_detail_Sortdsc);
            ucDdo_br_scheme_chem_detail.SetProperty("SearchButtonText", Ddo_br_scheme_chem_detail_Searchbuttontext);
            ucDdo_br_scheme_chem_detail.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_detail.SetProperty("DropDownOptionsData", AV23BR_Scheme_Chem_DetailTitleFilterData);
            ucDdo_br_scheme_chem_detail.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_detail_Internalname, "DDO_BR_SCHEME_CHEM_DETAILContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemePrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemePrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_SchemePrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 12 )
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
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START6F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择化疗方案", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6F0( ) ;
      }

      protected void WS6F2( )
      {
         START6F2( ) ;
         EVT6F2( ) ;
      }

      protected void EVT6F2( )
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
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E116F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E126F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEMEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E136F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E146F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E156F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E166F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E176F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E186F2 ();
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                        {
                           nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                           SubsflControlProps_122( ) ;
                           AV30Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)) ? AV34Select_GXI : context.convertURL( context.PathToRelativeUrl( AV30Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV30Select), true);
                           A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
                           n328BR_Scheme_Chem_Regimens = false;
                           A329BR_Scheme_Therapy_Line = cgiGet( edtBR_Scheme_Therapy_Line_Internalname);
                           n329BR_Scheme_Therapy_Line = false;
                           A330BR_Scheme_Chem_Cycle = context.localUtil.CToN( cgiGet( edtBR_Scheme_Chem_Cycle_Internalname), ".", ",");
                           n330BR_Scheme_Chem_Cycle = false;
                           A331BR_Scheme_Chem_Detail = cgiGet( edtBR_Scheme_Chem_Detail_Internalname);
                           n331BR_Scheme_Chem_Detail = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E196F2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E206F2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E216F2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Orderedby Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV11OrderedBy )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordereddsc Changed */
                                    if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
                                    {
                                       Rfr0gs = true;
                                    }
                                    if ( ! Rfr0gs )
                                    {
                                       /* Execute user event: Enter */
                                       E226F2 ();
                                    }
                                    dynload_actions( ) ;
                                 }
                                 /* No code required for Cancel button. It is implemented as the Reset button. */
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
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

      protected void WE6F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6F2( ) ;
            }
         }
      }

      protected void PA6F2( )
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
               GX_FocusControl = edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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
         SubsflControlProps_122( ) ;
         while ( nGXsfl_12_idx <= nRC_GXsfl_12 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV14ddo_BR_SchemeIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ,
                                       String AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace ,
                                       String AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace ,
                                       String AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6F2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEME_CHEM_REGIMENS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A328BR_Scheme_Chem_Regimens, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_SCHEME_CHEM_REGIMENS", A328BR_Scheme_Chem_Regimens);
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
         RF6F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV33Pgmname = "BR_SchemePrompt";
         context.Gx_err = 0;
      }

      protected void RF6F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E206F2 ();
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         bGXsfl_12_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
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
            SubsflControlProps_122( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H006F2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A331BR_Scheme_Chem_Detail = H006F2_A331BR_Scheme_Chem_Detail[0];
               n331BR_Scheme_Chem_Detail = H006F2_n331BR_Scheme_Chem_Detail[0];
               A330BR_Scheme_Chem_Cycle = H006F2_A330BR_Scheme_Chem_Cycle[0];
               n330BR_Scheme_Chem_Cycle = H006F2_n330BR_Scheme_Chem_Cycle[0];
               A329BR_Scheme_Therapy_Line = H006F2_A329BR_Scheme_Therapy_Line[0];
               n329BR_Scheme_Therapy_Line = H006F2_n329BR_Scheme_Therapy_Line[0];
               A328BR_Scheme_Chem_Regimens = H006F2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006F2_n328BR_Scheme_Chem_Regimens[0];
               A19BR_EncounterID = H006F2_A19BR_EncounterID[0];
               A327BR_SchemeID = H006F2_A327BR_SchemeID[0];
               E216F2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB6F0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6F2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEMEID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEME_CHEM_REGIMENS"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A328BR_Scheme_Chem_Regimens, "")), context));
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
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H006F3 */
         pr_default.execute(1);
         GRID_nRecordCount = H006F3_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_SchemeIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_SchemeIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_SchemeIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_SchemeIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace) ;
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_SchemeIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6F0( )
      {
         /* Before Start, stand alone formulas. */
         AV33Pgmname = "BR_SchemePrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E196F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV25DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEMEIDTITLEFILTERDATA"), AV13BR_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV15BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA"), AV17BR_Scheme_Chem_RegimensTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_THERAPY_LINETITLEFILTERDATA"), AV19BR_Scheme_Therapy_LineTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA"), AV21BR_Scheme_Chem_CycleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA"), AV23BR_Scheme_Chem_DetailTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_SchemeIDTitleControlIdToReplace", AV14ddo_BR_SchemeIDTitleControlIdToReplace);
            AV16ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
            AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
            AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace", AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace);
            AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace", AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace);
            AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace", AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            else
            {
               AV11OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            AV12OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ".", ","));
            AV27GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV29GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV28GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Class = cgiGet( "GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( "GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( "GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( "GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( "GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( "GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_schemeid_Caption = cgiGet( "DDO_BR_SCHEMEID_Caption");
            Ddo_br_schemeid_Tooltip = cgiGet( "DDO_BR_SCHEMEID_Tooltip");
            Ddo_br_schemeid_Cls = cgiGet( "DDO_BR_SCHEMEID_Cls");
            Ddo_br_schemeid_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEMEID_Dropdownoptionstype");
            Ddo_br_schemeid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEMEID_Titlecontrolidtoreplace");
            Ddo_br_schemeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortasc"));
            Ddo_br_schemeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortdsc"));
            Ddo_br_schemeid_Sortedstatus = cgiGet( "DDO_BR_SCHEMEID_Sortedstatus");
            Ddo_br_schemeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includefilter"));
            Ddo_br_schemeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includedatalist"));
            Ddo_br_schemeid_Sortasc = cgiGet( "DDO_BR_SCHEMEID_Sortasc");
            Ddo_br_schemeid_Sortdsc = cgiGet( "DDO_BR_SCHEMEID_Sortdsc");
            Ddo_br_schemeid_Searchbuttontext = cgiGet( "DDO_BR_SCHEMEID_Searchbuttontext");
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_scheme_chem_regimens_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Caption");
            Ddo_br_scheme_chem_regimens_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip");
            Ddo_br_scheme_chem_regimens_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Cls");
            Ddo_br_scheme_chem_regimens_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype");
            Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_regimens_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc"));
            Ddo_br_scheme_chem_regimens_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc"));
            Ddo_br_scheme_chem_regimens_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus");
            Ddo_br_scheme_chem_regimens_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter"));
            Ddo_br_scheme_chem_regimens_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist"));
            Ddo_br_scheme_chem_regimens_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc");
            Ddo_br_scheme_chem_regimens_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc");
            Ddo_br_scheme_chem_regimens_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext");
            Ddo_br_scheme_therapy_line_Caption = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Caption");
            Ddo_br_scheme_therapy_line_Tooltip = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Tooltip");
            Ddo_br_scheme_therapy_line_Cls = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Cls");
            Ddo_br_scheme_therapy_line_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Dropdownoptionstype");
            Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Titlecontrolidtoreplace");
            Ddo_br_scheme_therapy_line_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includesortasc"));
            Ddo_br_scheme_therapy_line_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includesortdsc"));
            Ddo_br_scheme_therapy_line_Sortedstatus = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Sortedstatus");
            Ddo_br_scheme_therapy_line_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includefilter"));
            Ddo_br_scheme_therapy_line_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includedatalist"));
            Ddo_br_scheme_therapy_line_Sortasc = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Sortasc");
            Ddo_br_scheme_therapy_line_Sortdsc = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Sortdsc");
            Ddo_br_scheme_therapy_line_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Searchbuttontext");
            Ddo_br_scheme_chem_cycle_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Caption");
            Ddo_br_scheme_chem_cycle_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Tooltip");
            Ddo_br_scheme_chem_cycle_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Cls");
            Ddo_br_scheme_chem_cycle_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Dropdownoptionstype");
            Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_cycle_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includesortasc"));
            Ddo_br_scheme_chem_cycle_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includesortdsc"));
            Ddo_br_scheme_chem_cycle_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Sortedstatus");
            Ddo_br_scheme_chem_cycle_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includefilter"));
            Ddo_br_scheme_chem_cycle_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includedatalist"));
            Ddo_br_scheme_chem_cycle_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Sortasc");
            Ddo_br_scheme_chem_cycle_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Sortdsc");
            Ddo_br_scheme_chem_cycle_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Searchbuttontext");
            Ddo_br_scheme_chem_detail_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Caption");
            Ddo_br_scheme_chem_detail_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Tooltip");
            Ddo_br_scheme_chem_detail_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Cls");
            Ddo_br_scheme_chem_detail_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Dropdownoptionstype");
            Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_detail_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includesortasc"));
            Ddo_br_scheme_chem_detail_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includesortdsc"));
            Ddo_br_scheme_chem_detail_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Sortedstatus");
            Ddo_br_scheme_chem_detail_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includefilter"));
            Ddo_br_scheme_chem_detail_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includedatalist"));
            Ddo_br_scheme_chem_detail_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Sortasc");
            Ddo_br_scheme_chem_detail_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Sortdsc");
            Ddo_br_scheme_chem_detail_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_schemeid_Activeeventkey = cgiGet( "DDO_BR_SCHEMEID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_scheme_chem_regimens_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey");
            Ddo_br_scheme_therapy_line_Activeeventkey = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Activeeventkey");
            Ddo_br_scheme_chem_cycle_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Activeeventkey");
            Ddo_br_scheme_chem_detail_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV11OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
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
         E196F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E196F2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Scheme", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV33Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_SchemeID";
         ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_schemeid_Titlecontrolidtoreplace);
         AV14ddo_BR_SchemeIDTitleControlIdToReplace = Ddo_br_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_SchemeIDTitleControlIdToReplace", AV14ddo_BR_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Regimens";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace);
         AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Therapy_Line";
         ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace);
         AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace", AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace);
         edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Cycle";
         ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace);
         AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace", AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Detail";
         ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace);
         AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace", AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择化疗方案";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV11OrderedBy < 1 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV25DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV25DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E206F2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Scheme_Therapy_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Scheme_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Scheme_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_SchemeID_Titleformat = 2;
         edtBR_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案主键", AV14ddo_BR_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Title", edtBR_SchemeID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Scheme_Chem_Regimens_Titleformat = 2;
         edtBR_Scheme_Chem_Regimens_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案", AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Regimens_Internalname, "Title", edtBR_Scheme_Chem_Regimens_Title, !bGXsfl_12_Refreshing);
         edtBR_Scheme_Therapy_Line_Titleformat = 2;
         edtBR_Scheme_Therapy_Line_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "方案线级", AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Therapy_Line_Internalname, "Title", edtBR_Scheme_Therapy_Line_Title, !bGXsfl_12_Refreshing);
         edtBR_Scheme_Chem_Cycle_Titleformat = 2;
         edtBR_Scheme_Chem_Cycle_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗周期", AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Cycle_Internalname, "Title", edtBR_Scheme_Chem_Cycle_Title, !bGXsfl_12_Refreshing);
         edtBR_Scheme_Chem_Detail_Titleformat = 2;
         edtBR_Scheme_Chem_Detail_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案描述", AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Detail_Internalname, "Title", edtBR_Scheme_Chem_Detail_Title, !bGXsfl_12_Refreshing);
         AV27GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridCurrentPage), 10, 0)));
         AV28GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridPageSize), 10, 0)));
         AV29GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E116F2( )
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
            AV26PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV26PageToGo) ;
         }
      }

      protected void E126F2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136F2( )
      {
         /* Ddo_br_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_schemeid_Sortedstatus = "ASC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_schemeid_Sortedstatus = "DSC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E146F2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E156F2( )
      {
         /* Ddo_br_scheme_chem_regimens_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_chem_regimens_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_chem_regimens_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E166F2( )
      {
         /* Ddo_br_scheme_therapy_line_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_therapy_line_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_therapy_line_Sortedstatus = "ASC";
            ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SortedStatus", Ddo_br_scheme_therapy_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_therapy_line_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_therapy_line_Sortedstatus = "DSC";
            ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SortedStatus", Ddo_br_scheme_therapy_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E176F2( )
      {
         /* Ddo_br_scheme_chem_cycle_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_cycle_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_chem_cycle_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "SortedStatus", Ddo_br_scheme_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_cycle_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_chem_cycle_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "SortedStatus", Ddo_br_scheme_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E186F2( )
      {
         /* Ddo_br_scheme_chem_detail_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_detail_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_chem_detail_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SortedStatus", Ddo_br_scheme_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_detail_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_scheme_chem_detail_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SortedStatus", Ddo_br_scheme_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_SchemeIDTitleFilterData", AV13BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Scheme_Therapy_LineTitleFilterData", AV19BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Scheme_Chem_CycleTitleFilterData", AV21BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Scheme_Chem_DetailTitleFilterData", AV23BR_Scheme_Chem_DetailTitleFilterData);
      }

      private void E216F2( )
      {
         /* Grid_Load Routine */
         AV30Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV30Select);
         AV34Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "选择";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12;
         }
         sendrow_122( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_12_Refreshing )
         {
            context.DoAjaxLoad(12, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E226F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E226F2( )
      {
         /* Enter Routine */
         AV8InOutBR_SchemeID = A327BR_SchemeID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_SchemeID), 18, 0)));
         AV9InOutBR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Scheme_Chem_Regimens", AV9InOutBR_Scheme_Chem_Regimens);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_SchemeID,(String)AV9InOutBR_Scheme_Chem_Regimens});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_SchemeID","AV9InOutBR_Scheme_Chem_Regimens"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8InOutBR_SchemeID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_SchemeID), 18, 0)));
         AV9InOutBR_Scheme_Chem_Regimens = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Scheme_Chem_Regimens", AV9InOutBR_Scheme_Chem_Regimens);
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
         PA6F2( ) ;
         WS6F2( ) ;
         WE6F2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815152592", true);
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
         context.AddJavascriptSource("br_schemeprompt.js", "?202022815152592", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_12_idx;
         edtBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE_"+sGXsfl_12_idx;
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE_"+sGXsfl_12_idx;
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_12_fel_idx;
         edtBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE_"+sGXsfl_12_fel_idx;
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE_"+sGXsfl_12_fel_idx;
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB6F0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_12_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_12_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'',false,'',12)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV30Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV30Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV34Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)) ? AV34Select_GXI : context.PathToRelativeUrl( AV30Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV30Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_SchemeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_SchemeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Regimens_Internalname,(String)A328BR_Scheme_Chem_Regimens,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Regimens_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Therapy_Line_Internalname,(String)A329BR_Scheme_Therapy_Line,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Therapy_Line_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Cycle_Internalname,StringUtil.LTrim( StringUtil.NToC( A330BR_Scheme_Chem_Cycle, 15, 5, ".", "")),context.localUtil.Format( A330BR_Scheme_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Cycle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Detail_Internalname,(String)A331BR_Scheme_Chem_Detail,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Detail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6F2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_SchemeID_Internalname = "BR_SCHEMEID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS";
         edtBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE";
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE";
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_schemeid_Internalname = "DDO_BR_SCHEMEID";
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_regimens_Internalname = "DDO_BR_SCHEME_CHEM_REGIMENS";
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_therapy_line_Internalname = "DDO_BR_SCHEME_THERAPY_LINE";
         edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_cycle_Internalname = "DDO_BR_SCHEME_CHEM_CYCLE";
         edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_detail_Internalname = "DDO_BR_SCHEME_CHEM_DETAIL";
         edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtBR_Scheme_Chem_Detail_Jsonclick = "";
         edtBR_Scheme_Chem_Cycle_Jsonclick = "";
         edtBR_Scheme_Therapy_Line_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_SchemeID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Scheme_Chem_Detail_Titleformat = 0;
         edtBR_Scheme_Chem_Detail_Title = "化疗方案描述";
         edtBR_Scheme_Chem_Cycle_Titleformat = 0;
         edtBR_Scheme_Chem_Cycle_Title = "化疗周期";
         edtBR_Scheme_Therapy_Line_Titleformat = 0;
         edtBR_Scheme_Therapy_Line_Title = "方案线级";
         edtBR_Scheme_Chem_Regimens_Titleformat = 0;
         edtBR_Scheme_Chem_Regimens_Title = "化疗方案";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_SchemeID_Titleformat = 0;
         edtBR_SchemeID_Title = "化疗方案主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_scheme_chem_detail_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_detail_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_detail_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_detail_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_detail_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_detail_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_detail_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_detail_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_detail_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_detail_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_detail_Caption = "";
         Ddo_br_scheme_chem_cycle_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_cycle_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_cycle_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_cycle_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_cycle_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_cycle_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_cycle_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_cycle_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_cycle_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_cycle_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_cycle_Caption = "";
         Ddo_br_scheme_therapy_line_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_therapy_line_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_therapy_line_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_therapy_line_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_therapy_line_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_scheme_therapy_line_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_therapy_line_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_therapy_line_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_therapy_line_Cls = "ColumnSettings";
         Ddo_br_scheme_therapy_line_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_therapy_line_Caption = "";
         Ddo_br_scheme_chem_regimens_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_regimens_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_regimens_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_regimens_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_regimens_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_regimens_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_regimens_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_regimens_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_regimens_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_regimens_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
         Ddo_br_schemeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_schemeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_schemeid_Sortasc = "WWP_TSSortASC";
         Ddo_br_schemeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_schemeid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_schemeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Titlecontrolidtoreplace = "";
         Ddo_br_schemeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_schemeid_Cls = "ColumnSettings";
         Ddo_br_schemeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_schemeid_Caption = "";
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
         Form.Caption = "选择化疗方案";
         subGrid_Rows = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED","{handler:'E136F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_schemeid_Activeeventkey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E146F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED","{handler:'E156F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_scheme_chem_regimens_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED","{handler:'E166F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_scheme_therapy_line_Activeeventkey',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED","{handler:'E176F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_scheme_chem_cycle_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED","{handler:'E186F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_scheme_chem_detail_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV13BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV19BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV21BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV23BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E216F2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV30Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E226F2',iparms:[{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A328BR_Scheme_Chem_Regimens',fld:'BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_SchemeID',fld:'vINOUTBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_Scheme_Chem_Regimens',fld:'vINOUTBR_SCHEME_CHEM_REGIMENS',pic:''}]}");
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
         wcpOAV9InOutBR_Scheme_Chem_Regimens = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_schemeid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_scheme_chem_regimens_Activeeventkey = "";
         Ddo_br_scheme_therapy_line_Activeeventkey = "";
         Ddo_br_scheme_chem_cycle_Activeeventkey = "";
         Ddo_br_scheme_chem_detail_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_SchemeIDTitleControlIdToReplace = "";
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "";
         AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = "";
         AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = "";
         AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = "";
         GXKey = "";
         AV33Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV25DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Scheme_Therapy_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Scheme_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Scheme_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_schemeid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         Ddo_br_scheme_therapy_line_Sortedstatus = "";
         Ddo_br_scheme_chem_cycle_Sortedstatus = "";
         Ddo_br_scheme_chem_detail_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV30Select = "";
         A328BR_Scheme_Chem_Regimens = "";
         A329BR_Scheme_Therapy_Line = "";
         A331BR_Scheme_Chem_Detail = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_schemeid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_scheme_chem_regimens = new GXUserControl();
         ucDdo_br_scheme_therapy_line = new GXUserControl();
         ucDdo_br_scheme_chem_cycle = new GXUserControl();
         ucDdo_br_scheme_chem_detail = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV34Select_GXI = "";
         scmdbuf = "";
         H006F2_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         H006F2_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         H006F2_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         H006F2_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         H006F2_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         H006F2_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         H006F2_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         H006F2_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         H006F2_A19BR_EncounterID = new long[1] ;
         H006F2_A327BR_SchemeID = new long[1] ;
         H006F3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_schemeprompt__default(),
            new Object[][] {
                new Object[] {
               H006F2_A331BR_Scheme_Chem_Detail, H006F2_n331BR_Scheme_Chem_Detail, H006F2_A330BR_Scheme_Chem_Cycle, H006F2_n330BR_Scheme_Chem_Cycle, H006F2_A329BR_Scheme_Therapy_Line, H006F2_n329BR_Scheme_Therapy_Line, H006F2_A328BR_Scheme_Chem_Regimens, H006F2_n328BR_Scheme_Chem_Regimens, H006F2_A19BR_EncounterID, H006F2_A327BR_SchemeID
               }
               , new Object[] {
               H006F3_AGRID_nRecordCount
               }
            }
         );
         AV33Pgmname = "BR_SchemePrompt";
         /* GeneXus formulas. */
         AV33Pgmname = "BR_SchemePrompt";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV11OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_SchemeID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Scheme_Chem_Regimens_Titleformat ;
      private short edtBR_Scheme_Therapy_Line_Titleformat ;
      private short edtBR_Scheme_Chem_Cycle_Titleformat ;
      private short edtBR_Scheme_Chem_Detail_Titleformat ;
      private short subGrid_Sortable ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int divTablemain_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV26PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_SchemeID ;
      private long wcpOAV8InOutBR_SchemeID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV27GridCurrentPage ;
      private long AV29GridRecordCount ;
      private long AV28GridPageSize ;
      private long A327BR_SchemeID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A330BR_Scheme_Chem_Cycle ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_schemeid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_scheme_chem_regimens_Activeeventkey ;
      private String Ddo_br_scheme_therapy_line_Activeeventkey ;
      private String Ddo_br_scheme_chem_cycle_Activeeventkey ;
      private String Ddo_br_scheme_chem_detail_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV33Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String Ddo_br_schemeid_Caption ;
      private String Ddo_br_schemeid_Tooltip ;
      private String Ddo_br_schemeid_Cls ;
      private String Ddo_br_schemeid_Dropdownoptionstype ;
      private String Ddo_br_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_schemeid_Sortedstatus ;
      private String Ddo_br_schemeid_Sortasc ;
      private String Ddo_br_schemeid_Sortdsc ;
      private String Ddo_br_schemeid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_scheme_chem_regimens_Caption ;
      private String Ddo_br_scheme_chem_regimens_Tooltip ;
      private String Ddo_br_scheme_chem_regimens_Cls ;
      private String Ddo_br_scheme_chem_regimens_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_regimens_Sortedstatus ;
      private String Ddo_br_scheme_chem_regimens_Sortasc ;
      private String Ddo_br_scheme_chem_regimens_Sortdsc ;
      private String Ddo_br_scheme_chem_regimens_Searchbuttontext ;
      private String Ddo_br_scheme_therapy_line_Caption ;
      private String Ddo_br_scheme_therapy_line_Tooltip ;
      private String Ddo_br_scheme_therapy_line_Cls ;
      private String Ddo_br_scheme_therapy_line_Dropdownoptionstype ;
      private String Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_therapy_line_Sortedstatus ;
      private String Ddo_br_scheme_therapy_line_Sortasc ;
      private String Ddo_br_scheme_therapy_line_Sortdsc ;
      private String Ddo_br_scheme_therapy_line_Searchbuttontext ;
      private String Ddo_br_scheme_chem_cycle_Caption ;
      private String Ddo_br_scheme_chem_cycle_Tooltip ;
      private String Ddo_br_scheme_chem_cycle_Cls ;
      private String Ddo_br_scheme_chem_cycle_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_cycle_Sortedstatus ;
      private String Ddo_br_scheme_chem_cycle_Sortasc ;
      private String Ddo_br_scheme_chem_cycle_Sortdsc ;
      private String Ddo_br_scheme_chem_cycle_Searchbuttontext ;
      private String Ddo_br_scheme_chem_detail_Caption ;
      private String Ddo_br_scheme_chem_detail_Tooltip ;
      private String Ddo_br_scheme_chem_detail_Cls ;
      private String Ddo_br_scheme_chem_detail_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_detail_Sortedstatus ;
      private String Ddo_br_scheme_chem_detail_Sortasc ;
      private String Ddo_br_scheme_chem_detail_Sortdsc ;
      private String Ddo_br_scheme_chem_detail_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_SchemeID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Scheme_Chem_Regimens_Title ;
      private String edtBR_Scheme_Therapy_Line_Title ;
      private String edtBR_Scheme_Chem_Cycle_Title ;
      private String edtBR_Scheme_Chem_Detail_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_schemeid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_regimens_Internalname ;
      private String edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_therapy_line_Internalname ;
      private String edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_cycle_Internalname ;
      private String edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_detail_Internalname ;
      private String edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSelect_Internalname ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Scheme_Therapy_Line_Internalname ;
      private String edtBR_Scheme_Chem_Cycle_Internalname ;
      private String edtBR_Scheme_Chem_Detail_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_SchemeID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String edtBR_Scheme_Therapy_Line_Jsonclick ;
      private String edtBR_Scheme_Chem_Cycle_Jsonclick ;
      private String edtBR_Scheme_Chem_Detail_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_schemeid_Includesortasc ;
      private bool Ddo_br_schemeid_Includesortdsc ;
      private bool Ddo_br_schemeid_Includefilter ;
      private bool Ddo_br_schemeid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_scheme_chem_regimens_Includesortasc ;
      private bool Ddo_br_scheme_chem_regimens_Includesortdsc ;
      private bool Ddo_br_scheme_chem_regimens_Includefilter ;
      private bool Ddo_br_scheme_chem_regimens_Includedatalist ;
      private bool Ddo_br_scheme_therapy_line_Includesortasc ;
      private bool Ddo_br_scheme_therapy_line_Includesortdsc ;
      private bool Ddo_br_scheme_therapy_line_Includefilter ;
      private bool Ddo_br_scheme_therapy_line_Includedatalist ;
      private bool Ddo_br_scheme_chem_cycle_Includesortasc ;
      private bool Ddo_br_scheme_chem_cycle_Includesortdsc ;
      private bool Ddo_br_scheme_chem_cycle_Includefilter ;
      private bool Ddo_br_scheme_chem_cycle_Includedatalist ;
      private bool Ddo_br_scheme_chem_detail_Includesortasc ;
      private bool Ddo_br_scheme_chem_detail_Includesortdsc ;
      private bool Ddo_br_scheme_chem_detail_Includefilter ;
      private bool Ddo_br_scheme_chem_detail_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n329BR_Scheme_Therapy_Line ;
      private bool n330BR_Scheme_Chem_Cycle ;
      private bool n331BR_Scheme_Chem_Detail ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV30Select_IsBlob ;
      private String AV9InOutBR_Scheme_Chem_Regimens ;
      private String wcpOAV9InOutBR_Scheme_Chem_Regimens ;
      private String AV14ddo_BR_SchemeIDTitleControlIdToReplace ;
      private String AV16ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ;
      private String AV20ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace ;
      private String AV22ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace ;
      private String AV24ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A329BR_Scheme_Therapy_Line ;
      private String A331BR_Scheme_Chem_Detail ;
      private String AV34Select_GXI ;
      private String AV30Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_schemeid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_scheme_chem_regimens ;
      private GXUserControl ucDdo_br_scheme_therapy_line ;
      private GXUserControl ucDdo_br_scheme_chem_cycle ;
      private GXUserControl ucDdo_br_scheme_chem_detail ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_SchemeID ;
      private String aP1_InOutBR_Scheme_Chem_Regimens ;
      private IDataStoreProvider pr_default ;
      private String[] H006F2_A331BR_Scheme_Chem_Detail ;
      private bool[] H006F2_n331BR_Scheme_Chem_Detail ;
      private decimal[] H006F2_A330BR_Scheme_Chem_Cycle ;
      private bool[] H006F2_n330BR_Scheme_Chem_Cycle ;
      private String[] H006F2_A329BR_Scheme_Therapy_Line ;
      private bool[] H006F2_n329BR_Scheme_Therapy_Line ;
      private String[] H006F2_A328BR_Scheme_Chem_Regimens ;
      private bool[] H006F2_n328BR_Scheme_Chem_Regimens ;
      private long[] H006F2_A19BR_EncounterID ;
      private long[] H006F2_A327BR_SchemeID ;
      private long[] H006F3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Scheme_Chem_RegimensTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Scheme_Therapy_LineTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Scheme_Chem_CycleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Scheme_Chem_DetailTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV25DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_schemeprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006F2( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [3] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Scheme_Chem_Detail], [BR_Scheme_Chem_Cycle], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Regimens], [BR_EncounterID], [BR_SchemeID]";
         sFromString = " FROM [BR_Scheme] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_SchemeID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_SchemeID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Regimens]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Regimens] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Therapy_Line]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Therapy_Line] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Cycle]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Cycle] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Detail]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Detail] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_SchemeID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H006F3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Scheme] WITH (NOLOCK)";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object5[0] = scmdbuf;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H006F2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H006F3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH006F2 ;
          prmH006F2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006F3 ;
          prmH006F3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H006F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006F2,11,0,true,false )
             ,new CursorDef("H006F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006F3,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
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
                   stmt.SetParameter(sIdx, (int)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                return;
       }
    }

 }

}

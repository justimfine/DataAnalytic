/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:8:14.59
*/
gx.evt.autoSkip=!1;gx.define("br_medication_scheme",!1,function(){var n,t;this.ServerClass="br_medication_scheme";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7BR_Medication_SchemeID=gx.fn.getIntegerValue("vBR_MEDICATION_SCHEMEID",",");this.AV13Insert_BR_MedicationID=gx.fn.getIntegerValue("vINSERT_BR_MEDICATIONID",",");this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Br_medication_schemeid=function(){try{var n=gx.util.balloon.getNew("BR_MEDICATION_SCHEMEID");this.AnyError=0;this.refreshOutputs([{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Br_medication_chem_name=function(){try{var n=gx.util.balloon.getNew("BR_MEDICATION_CHEM_NAME");if(this.AnyError=0,""==this.A305BR_Medication_Chem_Name)try{n.setError("化疗方案名称是必须填写的。");this.AnyError=gx.num.trunc(1,0)}catch(t){}this.refreshOutputs([{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Br_medication_chem_line=function(){try{var n=gx.util.balloon.getNew("BR_MEDICATION_CHEM_LINE");this.AnyError=0;try{gx.fn.setCtrlProperty("vVLINE","Visible",this.A307BR_Medication_Chem_Line=="其它")}catch(t){}try{this.A307BR_Medication_Chem_Line=="其它"?this.A307BR_Medication_Chem_Line=="其它"&&gx.fn.setCtrlProperty("VLINE_CELL","Class","RequiredDataContentCell"):gx.fn.setCtrlProperty("VLINE_CELL","Class","Invisible")}catch(t){}this.refreshOutputs([{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Validv_Vline=function(){try{var n=gx.util.balloon.getNew("vVLINE");if(this.AnyError=0,this.A307BR_Medication_Chem_Line=="其它"&&""==this.AV15vLine)try{n.setError("其它线级是必填的");this.AnyError=gx.num.trunc(1,0)}catch(t){}this.refreshOutputs([{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}])}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Br_medicationid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Br_medicationid",["gx.num.urlDecimal(gx.O.A119BR_MedicationID,',','.')"],[]),!0};this.s112_client=function(){gx.fn.setCtrlProperty("vVLINE","Visible",!1);gx.fn.setCtrlProperty("VLINE_CELL","Class","Invisible")};this.e120v2_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e130v32_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e140v32_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,39,40,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66];this.GXLastCtrlId=66;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","药物治疗化疗方案","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_chem_name,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_NAME",gxz:"Z305BR_Medication_Chem_Name",gxold:"O305BR_Medication_Chem_Name",gxvar:"A305BR_Medication_Chem_Name",ucs:[],op:[25],ip:[25],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A305BR_Medication_Chem_Name=n)},v2z:function(n){n!==undefined&&(gx.O.Z305BR_Medication_Chem_Name=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_CHEM_NAME",gx.O.A305BR_Medication_Chem_Name,0)},c2v:function(){this.val()!==undefined&&(gx.O.A305BR_Medication_Chem_Name=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_CHEM_NAME")},nac:gx.falseFn};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,lvl:0,type:"decimal",len:15,dec:5,sign:!1,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_CYCLE",gxz:"Z306BR_Medication_Chem_Cycle",gxold:"O306BR_Medication_Chem_Cycle",gxvar:"A306BR_Medication_Chem_Cycle",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A306BR_Medication_Chem_Cycle=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z306BR_Medication_Chem_Cycle=gx.fn.toDecimalValue(n,",","."))},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_CHEM_CYCLE",gx.O.A306BR_Medication_Chem_Cycle,5,".");typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A306BR_Medication_Chem_Cycle=this.val())},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_CHEM_CYCLE",",",".")},nac:gx.falseFn};this.declareDomainHdlr(29,function(){});n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"TABLESPLITTEDBR_MEDICATION_CHEM_LINE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"TEXTBLOCKBR_MEDICATION_CHEM_LINE",format:0,grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"TABLEMERGEDBR_MEDICATION_CHEM_LINE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_chem_line,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_LINE",gxz:"Z307BR_Medication_Chem_Line",gxold:"O307BR_Medication_Chem_Line",gxvar:"A307BR_Medication_Chem_Line",ucs:[],op:[],ip:[40],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.A307BR_Medication_Chem_Line=n)},v2z:function(n){n!==undefined&&(gx.O.Z307BR_Medication_Chem_Line=n)},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICATION_CHEM_LINE",gx.O.A307BR_Medication_Chem_Line)},c2v:function(){this.val()!==undefined&&(gx.O.A307BR_Medication_Chem_Line=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_CHEM_LINE")},nac:gx.falseFn};n[42]={id:42,fld:"",grid:0};n[43]={id:43,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vline,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVLINE",gxz:"ZV15vLine",gxold:"OV15vLine",gxvar:"AV15vLine",ucs:[],op:[43,40],ip:[43,40],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV15vLine=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15vLine=n)},v2c:function(){gx.fn.setControlValue("vVLINE",gx.O.AV15vLine,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15vLine=this.val())},val:function(){return gx.fn.getControlValue("vVLINE")},nac:gx.falseFn};n[44]={id:44,fld:"",grid:0};n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"UNNAMEDTABLEBR_MEDICATION_CHEM_DETAIL",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,fld:"TEXTBLOCKBR_MEDICATION_CHEM_DETAIL",format:0,grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_CHEM_DETAIL",gxz:"Z313BR_Medication_Chem_Detail",gxold:"O313BR_Medication_Chem_Detail",gxvar:"A313BR_Medication_Chem_Detail",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A313BR_Medication_Chem_Detail=n)},v2z:function(n){n!==undefined&&(gx.O.Z313BR_Medication_Chem_Detail=n)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_CHEM_DETAIL",gx.O.A313BR_Medication_Chem_Detail,0)},c2v:function(){this.val()!==undefined&&(gx.O.A313BR_Medication_Chem_Detail=this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICATION_CHEM_DETAIL")},nac:gx.falseFn};n[53]={id:53,fld:"",grid:0};n[54]={id:54,fld:"",grid:0};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"BTNTRN_ENTER",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,fld:"BTNTRN_CANCEL",grid:0};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"BTNTRN_DELETE",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[65]={id:65,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_SCHEMEID",gxz:"Z296BR_Medication_SchemeID",gxold:"O296BR_Medication_SchemeID",gxvar:"A296BR_Medication_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A296BR_Medication_SchemeID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z296BR_Medication_SchemeID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_SCHEMEID",gx.O.A296BR_Medication_SchemeID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A296BR_Medication_SchemeID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_SCHEMEID",",")},nac:gx.falseFn};this.declareDomainHdlr(65,function(){});n[66]={id:66,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[66],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A119BR_MedicationID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z119BR_MedicationID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_MEDICATIONID",gx.O.A119BR_MedicationID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A119BR_MedicationID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_MEDICATIONID",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV13Insert_BR_MedicationID)}};this.declareDomainHdlr(66,function(){});this.A305BR_Medication_Chem_Name="";this.Z305BR_Medication_Chem_Name="";this.O305BR_Medication_Chem_Name="";this.A306BR_Medication_Chem_Cycle=0;this.Z306BR_Medication_Chem_Cycle=0;this.O306BR_Medication_Chem_Cycle=0;this.A307BR_Medication_Chem_Line="";this.Z307BR_Medication_Chem_Line="";this.O307BR_Medication_Chem_Line="";this.AV15vLine="";this.ZV15vLine="";this.OV15vLine="";this.A313BR_Medication_Chem_Detail="";this.Z313BR_Medication_Chem_Detail="";this.O313BR_Medication_Chem_Detail="";this.A296BR_Medication_SchemeID=0;this.Z296BR_Medication_SchemeID=0;this.O296BR_Medication_SchemeID=0;this.A119BR_MedicationID=0;this.Z119BR_MedicationID=0;this.O119BR_MedicationID=0;this.AV8WWPContext={UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""};this.AV9IsAuthorized=!1;this.AV16Pgmname="";this.AV11TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV17GXV1=0;this.AV13Insert_BR_MedicationID=0;this.AV14TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7BR_Medication_SchemeID=0;this.AV12WebSession={};this.A296BR_Medication_SchemeID=0;this.A119BR_MedicationID=0;this.AV15vLine="";this.A305BR_Medication_Chem_Name="";this.A306BR_Medication_Chem_Cycle=0;this.A307BR_Medication_Chem_Line="";this.A313BR_Medication_Chem_Detail="";this.Gx_mode="";this.Events={e120v2_client:["AFTER TRN",!0],e130v32_client:["ENTER",!0],e140v32_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}],[{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7BR_Medication_SchemeID",fld:"vBR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"A296BR_Medication_SchemeID",fld:"BR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV13Insert_BR_MedicationID",fld:"vINSERT_BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}],[{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}]];this.EvtParms.START=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}],[{av:"AV8WWPContext",fld:"vWWPCONTEXT",pic:""},{av:"AV9IsAuthorized",fld:"vISAUTHORIZED",pic:""},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV17GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV14TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""},{av:"AV13Insert_BR_MedicationID",fld:"vINSERT_BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Visible")',ctrl:"BR_MEDICATION_SCHEMEID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Visible")',ctrl:"BR_MEDICATIONID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("vVLINE","Visible")',ctrl:"vVLINE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("VLINE_CELL","Class")',ctrl:"VLINE_CELL",prop:"Class"},{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV11TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"A296BR_Medication_SchemeID",fld:"BR_MEDICATION_SCHEMEID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"A119BR_MedicationID",fld:"BR_MEDICATIONID",pic:"ZZZZZZZZZZZZZZZZZZ"},{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}],[{ctrl:"BR_MEDICATION_CHEM_LINE"},{av:"A307BR_Medication_Chem_Line",fld:"BR_MEDICATION_CHEM_LINE",pic:""}]];this.EnterCtrl=["BTNTRN_ENTER"];this.setVCMap("AV7BR_Medication_SchemeID","vBR_MEDICATION_SCHEMEID",0,"int",18,0);this.setVCMap("AV13Insert_BR_MedicationID","vINSERT_BR_MEDICATIONID",0,"int",18,0);this.setVCMap("AV16Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV11TrnContext","vTRNCONTEXT",0,"WWPBaseObjectsWWPTransactionContext",0,0);this.Initialize()});gx.createParentObj(br_medication_scheme)
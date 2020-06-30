/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:4:58.58
*/
gx.evt.autoSkip=!1;gx.define("br_procedure_radiogeneral",!0,function(n){this.ServerClass="br_procedure_radiogeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_procedure_radioid=function(){try{var n=gx.util.balloon.getNew("BR_PROCEDURE_RADIOID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e13692_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14692_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31];this.GXLastCtrlId=31;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"UNNAMEDTABLEBR_PROCEDURE_RADIO_LOC",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"TEXTBLOCKBR_PROCEDURE_RADIO_LOC",format:0,grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIO_LOC",gxz:"Z324BR_Procedure_Radio_Loc",gxold:"O324BR_Procedure_Radio_Loc",gxvar:"A324BR_Procedure_Radio_Loc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A324BR_Procedure_Radio_Loc=n)},v2z:function(n){n!==undefined&&(gx.O.Z324BR_Procedure_Radio_Loc=n)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIO_LOC",gx.O.A324BR_Procedure_Radio_Loc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A324BR_Procedure_Radio_Loc=this.val())},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_RADIO_LOC")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"UNNAMEDTABLEBR_PROCEDURE_RADIO_AMOUNT",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"TEXTBLOCKBR_PROCEDURE_RADIO_AMOUNT",format:0,grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIO_AMOUNT",gxz:"Z325BR_Procedure_Radio_Amount",gxold:"O325BR_Procedure_Radio_Amount",gxvar:"A325BR_Procedure_Radio_Amount",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A325BR_Procedure_Radio_Amount=n)},v2z:function(n){n!==undefined&&(gx.O.Z325BR_Procedure_Radio_Amount=n)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIO_AMOUNT",gx.O.A325BR_Procedure_Radio_Amount,0)},c2v:function(){this.val()!==undefined&&(gx.O.A325BR_Procedure_Radio_Amount=this.val())},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_RADIO_AMOUNT")},nac:gx.falseFn};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[30]={id:30,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_radioid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIOID",gxz:"Z323BR_Procedure_RadioID",gxold:"O323BR_Procedure_RadioID",gxvar:"A323BR_Procedure_RadioID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A323BR_Procedure_RadioID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z323BR_Procedure_RadioID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIOID",gx.O.A323BR_Procedure_RadioID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A323BR_Procedure_RadioID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_RADIOID",",")},nac:gx.falseFn};this.declareDomainHdlr(30,function(){});t[31]={id:31,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A139BR_ProcedureID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z139BR_ProcedureID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PROCEDUREID",gx.O.A139BR_ProcedureID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A139BR_ProcedureID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PROCEDUREID",",")},nac:gx.falseFn};this.declareDomainHdlr(31,function(){});this.A324BR_Procedure_Radio_Loc="";this.Z324BR_Procedure_Radio_Loc="";this.O324BR_Procedure_Radio_Loc="";this.A325BR_Procedure_Radio_Amount="";this.Z325BR_Procedure_Radio_Amount="";this.O325BR_Procedure_Radio_Amount="";this.A323BR_Procedure_RadioID=0;this.Z323BR_Procedure_RadioID=0;this.O323BR_Procedure_RadioID=0;this.A139BR_ProcedureID=0;this.Z139BR_ProcedureID=0;this.O139BR_ProcedureID=0;this.A324BR_Procedure_Radio_Loc="";this.A325BR_Procedure_Radio_Amount="";this.A323BR_Procedure_RadioID=0;this.A139BR_ProcedureID=0;this.Events={e13692_client:["ENTER",!0],e14692_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_Procedure_RadioID",fld:"vBR_PROCEDURE_RADIOID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Visible")',ctrl:"BR_PROCEDURE_RADIOID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Visible")',ctrl:"BR_PROCEDUREID",prop:"Visible"}]];this.Initialize()})
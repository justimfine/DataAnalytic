/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:20.65
*/
gx.evt.autoSkip=!1;gx.define("xt_loggeneral",!0,function(n){this.ServerClass="xt_loggeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Xt_logid=function(){try{var n=gx.util.balloon.getNew("XT_LOGID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e114i1_client=function(){return this.clearMessages(),this.call("xt_log.aspx",["UPD",this.A173XT_LogID]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e124i1_client=function(){return this.clearMessages(),this.call("xt_log.aspx",["DLT",this.A173XT_LogID]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e154i2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e164i2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64];this.GXLastCtrlId=64;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGSECUSERNAME",gxz:"Z174XT_LogSecUserName",gxold:"O174XT_LogSecUserName",gxvar:"A174XT_LogSecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A174XT_LogSecUserName=n)},v2z:function(n){n!==undefined&&(gx.O.Z174XT_LogSecUserName=n)},v2c:function(){gx.fn.setControlValue("XT_LOGSECUSERNAME",gx.O.A174XT_LogSecUserName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A174XT_LogSecUserName=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGSECUSERNAME")},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTIME",gxz:"Z220XT_LogTime",gxold:"O220XT_LogTime",gxvar:"A220XT_LogTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A220XT_LogTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z220XT_LogTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("XT_LOGTIME",gx.O.A220XT_LogTime,0)},c2v:function(){this.val()!==undefined&&(gx.O.A220XT_LogTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("XT_LOGTIME")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGPROVIDERNAME",gxz:"Z219XT_LogProviderName",gxold:"O219XT_LogProviderName",gxvar:"A219XT_LogProviderName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A219XT_LogProviderName=n)},v2z:function(n){n!==undefined&&(gx.O.Z219XT_LogProviderName=n)},v2c:function(){gx.fn.setControlValue("XT_LOGPROVIDERNAME",gx.O.A219XT_LogProviderName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A219XT_LogProviderName=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGPROVIDERNAME")},nac:gx.falseFn};t[23]={id:23,fld:"",grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGETMODULE",gxz:"Z217XT_LogTargetModule",gxold:"O217XT_LogTargetModule",gxvar:"A217XT_LogTargetModule",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A217XT_LogTargetModule=n)},v2z:function(n){n!==undefined&&(gx.O.Z217XT_LogTargetModule=n)},v2c:function(){gx.fn.setControlValue("XT_LOGTARGETMODULE",gx.O.A217XT_LogTargetModule,0)},c2v:function(){this.val()!==undefined&&(gx.O.A217XT_LogTargetModule=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGTARGETMODULE")},nac:gx.falseFn};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"UNNAMEDTABLEXT_LOGTARGET",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,fld:"TEXTBLOCKXT_LOGTARGET",format:0,grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,lvl:0,type:"svchar",len:5e3,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGET",gxz:"Z216XT_LogTarget",gxold:"O216XT_LogTarget",gxvar:"A216XT_LogTarget",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A216XT_LogTarget=n)},v2z:function(n){n!==undefined&&(gx.O.Z216XT_LogTarget=n)},v2c:function(){gx.fn.setControlValue("XT_LOGTARGET",gx.O.A216XT_LogTarget,0)},c2v:function(){this.val()!==undefined&&(gx.O.A216XT_LogTarget=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGTARGET")},nac:gx.falseFn};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"UNNAMEDTABLEXT_LOGDESCRIPTION",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"TEXTBLOCKXT_LOGDESCRIPTION",format:0,grid:0};t[43]={id:43,fld:"",grid:0};t[44]={id:44,fld:"",grid:0};t[45]={id:45,lvl:0,type:"svchar",len:5e3,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGDESCRIPTION",gxz:"Z221XT_LogDescription",gxold:"O221XT_LogDescription",gxvar:"A221XT_LogDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A221XT_LogDescription=n)},v2z:function(n){n!==undefined&&(gx.O.Z221XT_LogDescription=n)},v2c:function(){gx.fn.setControlValue("XT_LOGDESCRIPTION",gx.O.A221XT_LogDescription,0)},c2v:function(){this.val()!==undefined&&(gx.O.A221XT_LogDescription=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGDESCRIPTION")},nac:gx.falseFn};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"",grid:0};t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"BTNUPDATE",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"BTNDELETE",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"",grid:0};t[55]={id:55,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[56]={id:56,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Xt_logid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGID",gxz:"Z173XT_LogID",gxold:"O173XT_LogID",gxvar:"A173XT_LogID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A173XT_LogID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z173XT_LogID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("XT_LOGID",gx.O.A173XT_LogID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A173XT_LogID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("XT_LOGID",",")},nac:gx.falseFn};this.declareDomainHdlr(56,function(){});t[57]={id:57,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGUSERID",gxz:"Z214XT_LogUserID",gxold:"O214XT_LogUserID",gxvar:"A214XT_LogUserID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A214XT_LogUserID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z214XT_LogUserID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("XT_LOGUSERID",gx.O.A214XT_LogUserID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A214XT_LogUserID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("XT_LOGUSERID",",")},nac:gx.falseFn};this.declareDomainHdlr(57,function(){});t[58]={id:58,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGPAGE",gxz:"Z176XT_LogPage",gxold:"O176XT_LogPage",gxvar:"A176XT_LogPage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A176XT_LogPage=n)},v2z:function(n){n!==undefined&&(gx.O.Z176XT_LogPage=n)},v2c:function(){gx.fn.setControlValue("XT_LOGPAGE",gx.O.A176XT_LogPage,0)},c2v:function(){this.val()!==undefined&&(gx.O.A176XT_LogPage=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGPAGE")},nac:gx.falseFn};t[59]={id:59,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGBUTTONNAME",gxz:"Z177XT_LogButtonName",gxold:"O177XT_LogButtonName",gxvar:"A177XT_LogButtonName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A177XT_LogButtonName=n)},v2z:function(n){n!==undefined&&(gx.O.Z177XT_LogButtonName=n)},v2c:function(){gx.fn.setControlValue("XT_LOGBUTTONNAME",gx.O.A177XT_LogButtonName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A177XT_LogButtonName=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGBUTTONNAME")},nac:gx.falseFn};t[60]={id:60,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTYPE",gxz:"Z213XT_LogType",gxold:"O213XT_LogType",gxvar:"A213XT_LogType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A213XT_LogType=n)},v2z:function(n){n!==undefined&&(gx.O.Z213XT_LogType=n)},v2c:function(){gx.fn.setControlValue("XT_LOGTYPE",gx.O.A213XT_LogType,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A213XT_LogType=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGTYPE")},nac:gx.falseFn};this.declareDomainHdlr(60,function(){});t[61]={id:61,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGPROVIDERID",gxz:"Z215XT_LogProviderID",gxold:"O215XT_LogProviderID",gxvar:"A215XT_LogProviderID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A215XT_LogProviderID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z215XT_LogProviderID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("XT_LOGPROVIDERID",gx.O.A215XT_LogProviderID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A215XT_LogProviderID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("XT_LOGPROVIDERID",",")},nac:gx.falseFn};this.declareDomainHdlr(61,function(){});t[62]={id:62,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGSONTARGET",gxz:"Z223XT_LogSonTarget",gxold:"O223XT_LogSonTarget",gxvar:"A223XT_LogSonTarget",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A223XT_LogSonTarget=n)},v2z:function(n){n!==undefined&&(gx.O.Z223XT_LogSonTarget=n)},v2c:function(){gx.fn.setControlValue("XT_LOGSONTARGET",gx.O.A223XT_LogSonTarget,0)},c2v:function(){this.val()!==undefined&&(gx.O.A223XT_LogSonTarget=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGSONTARGET")},nac:gx.falseFn};t[63]={id:63,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGETSONMODULE",gxz:"Z222XT_LogTargetSonModule",gxold:"O222XT_LogTargetSonModule",gxvar:"A222XT_LogTargetSonModule",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A222XT_LogTargetSonModule=n)},v2z:function(n){n!==undefined&&(gx.O.Z222XT_LogTargetSonModule=n)},v2c:function(){gx.fn.setControlValue("XT_LOGTARGETSONMODULE",gx.O.A222XT_LogTargetSonModule,0)},c2v:function(){this.val()!==undefined&&(gx.O.A222XT_LogTargetSonModule=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGTARGETSONMODULE")},nac:gx.falseFn};t[64]={id:64,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGETOPERATE",gxz:"Z218XT_LogTargetOperate",gxold:"O218XT_LogTargetOperate",gxvar:"A218XT_LogTargetOperate",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A218XT_LogTargetOperate=n)},v2z:function(n){n!==undefined&&(gx.O.Z218XT_LogTargetOperate=n)},v2c:function(){gx.fn.setComboBoxValue("XT_LOGTARGETOPERATE",gx.O.A218XT_LogTargetOperate);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A218XT_LogTargetOperate=this.val())},val:function(){return gx.fn.getControlValue("XT_LOGTARGETOPERATE")},nac:gx.falseFn};this.declareDomainHdlr(64,function(){});this.A174XT_LogSecUserName="";this.Z174XT_LogSecUserName="";this.O174XT_LogSecUserName="";this.A220XT_LogTime=gx.date.nullDate();this.Z220XT_LogTime=gx.date.nullDate();this.O220XT_LogTime=gx.date.nullDate();this.A219XT_LogProviderName="";this.Z219XT_LogProviderName="";this.O219XT_LogProviderName="";this.A217XT_LogTargetModule="";this.Z217XT_LogTargetModule="";this.O217XT_LogTargetModule="";this.A216XT_LogTarget="";this.Z216XT_LogTarget="";this.O216XT_LogTarget="";this.A221XT_LogDescription="";this.Z221XT_LogDescription="";this.O221XT_LogDescription="";this.A173XT_LogID=0;this.Z173XT_LogID=0;this.O173XT_LogID=0;this.A214XT_LogUserID=0;this.Z214XT_LogUserID=0;this.O214XT_LogUserID=0;this.A176XT_LogPage="";this.Z176XT_LogPage="";this.O176XT_LogPage="";this.A177XT_LogButtonName="";this.Z177XT_LogButtonName="";this.O177XT_LogButtonName="";this.A213XT_LogType="";this.Z213XT_LogType="";this.O213XT_LogType="";this.A215XT_LogProviderID=0;this.Z215XT_LogProviderID=0;this.O215XT_LogProviderID=0;this.A223XT_LogSonTarget="";this.Z223XT_LogSonTarget="";this.O223XT_LogSonTarget="";this.A222XT_LogTargetSonModule="";this.Z222XT_LogTargetSonModule="";this.O222XT_LogTargetSonModule="";this.A218XT_LogTargetOperate="";this.Z218XT_LogTargetOperate="";this.O218XT_LogTargetOperate="";this.A174XT_LogSecUserName="";this.A220XT_LogTime=gx.date.nullDate();this.A219XT_LogProviderName="";this.A217XT_LogTargetModule="";this.A216XT_LogTarget="";this.A221XT_LogDescription="";this.A173XT_LogID=0;this.A214XT_LogUserID=0;this.A176XT_LogPage="";this.A177XT_LogButtonName="";this.A213XT_LogType="";this.A215XT_LogProviderID=0;this.A223XT_LogSonTarget="";this.A222XT_LogTargetSonModule="";this.A218XT_LogTargetOperate="";this.Events={e154i2_client:["ENTER",!0],e164i2_client:["CANCEL",!0],e114i1_client:["'DOUPDATE'",!1],e124i1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8XT_LogID",fld:"vXT_LOGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("XT_LOGID","Visible")',ctrl:"XT_LOGID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGUSERID","Visible")',ctrl:"XT_LOGUSERID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGPAGE","Visible")',ctrl:"XT_LOGPAGE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGBUTTONNAME","Visible")',ctrl:"XT_LOGBUTTONNAME",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGTYPE","Visible")',ctrl:"XT_LOGTYPE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGPROVIDERID","Visible")',ctrl:"XT_LOGPROVIDERID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGSONTARGET","Visible")',ctrl:"XT_LOGSONTARGET",prop:"Visible"},{av:'gx.fn.getCtrlProperty("XT_LOGTARGETSONMODULE","Visible")',ctrl:"XT_LOGTARGETSONMODULE",prop:"Visible"},{ctrl:"XT_LOGTARGETOPERATE"},{ctrl:"BTNUPDATE",prop:"Visible"},{ctrl:"BTNDELETE",prop:"Visible"}]];this.EvtParms["'DOUPDATE'"]=[[{av:"A173XT_LogID",fld:"XT_LOGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A173XT_LogID",fld:"XT_LOGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.Initialize()})
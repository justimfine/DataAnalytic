/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:6:37.67
*/
gx.evt.autoSkip=!1;gx.define("br_encountercheckbehavior",!0,function(n){this.ServerClass="br_encountercheckbehavior";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV39Tcurrentcode=gx.fn.getDecimalValue("vTCURRENTCODE",",",".");this.A19BR_EncounterID=gx.fn.getIntegerValue("BR_ENCOUNTERID",",")};this.e133v2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e143v2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88];this.GXLastCtrlId=88;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"UNNAMEDTABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_SMOKING",gxz:"ZV19GXV1",gxold:"OV19GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV19GXV1=n)},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKING",gx.O.GXV1)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKING")},nac:gx.falseFn};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME",gxz:"ZV20GXV2",gxold:"OV20GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=n)},v2z:function(n){n!==undefined&&(gx.O.ZV20GXV2=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME")},nac:gx.falseFn};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[20]={id:20,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT",gxz:"ZV21GXV3",gxold:"OV21GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV3=n)},v2z:function(n){n!==undefined&&(gx.O.ZV21GXV3=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT",gx.O.GXV3,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT")},nac:gx.falseFn};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"",grid:0};t[24]={id:24,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT",gxz:"ZV22GXV4",gxold:"OV22GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV4=n)},v2z:function(n){n!==undefined&&(gx.O.ZV22GXV4=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT",gx.O.GXV4,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV4=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT")},nac:gx.falseFn};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL",gxz:"ZV23GXV5",gxold:"OV23GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(n){n!==undefined&&(gx.O.GXV5=n)},v2z:function(n){n!==undefined&&(gx.O.ZV23GXV5=n)},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL",gx.O.GXV5)},c2v:function(){this.val()!==undefined&&(gx.O.GXV5=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL")},nac:gx.falseFn};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME",gxz:"ZV24GXV6",gxold:"OV24GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV6=n)},v2z:function(n){n!==undefined&&(gx.O.ZV24GXV6=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME",gx.O.GXV6,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV6=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT",gxz:"ZV25GXV7",gxold:"OV25GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV7=n)},v2z:function(n){n!==undefined&&(gx.O.ZV25GXV7=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT",gx.O.GXV7,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV7=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT")},nac:gx.falseFn};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT",gxz:"ZV26GXV8",gxold:"OV26GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV8=n)},v2z:function(n){n!==undefined&&(gx.O.ZV26GXV8=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT",gx.O.GXV8,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV8=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT")},nac:gx.falseFn};t[43]={id:43,fld:"",grid:0};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM",gxz:"ZV27GXV9",gxold:"OV27GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV9=n)},v2z:function(n){n!==undefined&&(gx.O.ZV27GXV9=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM",gx.O.GXV9,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV9=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM")},nac:gx.falseFn};t[48]={id:48,fld:"",grid:0};t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY",gxz:"ZV28GXV10",gxold:"OV28GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV10=n)},v2z:function(n){n!==undefined&&(gx.O.ZV28GXV10=n)},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY",gx.O.GXV10)},c2v:function(){this.val()!==undefined&&(gx.O.GXV10=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY")},nac:gx.falseFn};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"CANCER",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,fld:"UNNAMEDTABLEBR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",grid:0};t[58]={id:58,fld:"",grid:0};t[59]={id:59,fld:"",grid:0};t[60]={id:60,fld:"TEXTBLOCKBR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",format:0,grid:0};t[61]={id:61,fld:"",grid:0};t[62]={id:62,fld:"",grid:0};t[63]={id:63,lvl:0,type:"svchar",len:200,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",gxz:"ZV29GXV11",gxold:"OV29GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV11=n)},v2z:function(n){n!==undefined&&(gx.O.ZV29GXV11=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER",gx.O.GXV11,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV11=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER")},nac:gx.falseFn};t[64]={id:64,fld:"",grid:0};t[65]={id:65,fld:"MANOPSUSE",grid:0};t[66]={id:66,fld:"",grid:0};t[67]={id:67,fld:"",grid:0};t[68]={id:68,fld:"",grid:0};t[69]={id:69,fld:"",grid:0};t[70]={id:70,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE",gxz:"ZV30GXV12",gxold:"OV30GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV12=n)},v2z:function(n){n!==undefined&&(gx.O.ZV30GXV12=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE",gx.O.GXV12,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV12=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE")},nac:gx.falseFn};t[71]={id:71,fld:"",grid:0};t[72]={id:72,fld:"",grid:0};t[73]={id:73,fld:"",grid:0};t[74]={id:74,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE",gxz:"ZV31GXV13",gxold:"OV31GXV13",gxvar:"GXV13",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.GXV13=n)},v2z:function(n){n!==undefined&&(gx.O.ZV31GXV13=n)},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE",gx.O.GXV13)},c2v:function(){this.val()!==undefined&&(gx.O.GXV13=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE")},nac:gx.falseFn};t[75]={id:75,fld:"",grid:0};t[76]={id:76,fld:"",grid:0};t[77]={id:77,fld:"AGE",grid:0};t[78]={id:78,fld:"",grid:0};t[79]={id:79,fld:"",grid:0};t[80]={id:80,fld:"",grid:0};t[81]={id:81,fld:"",grid:0};t[82]={id:82,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE",gxz:"ZV32GXV14",gxold:"OV32GXV14",gxvar:"GXV14",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV14=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV32GXV14=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE",gx.O.GXV14,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV14=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE",",")},nac:gx.falseFn};t[83]={id:83,fld:"",grid:0};t[84]={id:84,fld:"",grid:0};t[85]={id:85,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[86]={id:86,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_BEHAVIORID",gxz:"ZV33GXV15",gxold:"OV33GXV15",gxvar:"GXV15",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV15=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV33GXV15=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_BEHAVIORID",gx.O.GXV15,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV15=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_BR_BEHAVIORID",",")},nac:gx.falseFn};t[87]={id:87,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_ENCOUNTERID",gxz:"ZV34GXV16",gxold:"OV34GXV16",gxvar:"GXV16",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV16=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV34GXV16=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_ENCOUNTERID",gx.O.GXV16,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV16=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_BR_ENCOUNTERID",",")},nac:gx.falseFn};t[88]={id:88,lvl:0,type:"svchar",len:2e3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_BR_INFORMATION_PATIENTNO",gxz:"ZV35GXV17",gxold:"OV35GXV17",gxvar:"GXV17",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV17=n)},v2z:function(n){n!==undefined&&(gx.O.ZV35GXV17=n)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_BR_INFORMATION_PATIENTNO",gx.O.GXV17,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV17=this.val())},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};this.GXV1="";this.ZV19GXV1="";this.OV19GXV1="";this.GXV2="";this.ZV20GXV2="";this.OV20GXV2="";this.GXV3="";this.ZV21GXV3="";this.OV21GXV3="";this.GXV4="";this.ZV22GXV4="";this.OV22GXV4="";this.GXV5="";this.ZV23GXV5="";this.OV23GXV5="";this.GXV6="";this.ZV24GXV6="";this.OV24GXV6="";this.GXV7="";this.ZV25GXV7="";this.OV25GXV7="";this.GXV8="";this.ZV26GXV8="";this.OV26GXV8="";this.GXV9="";this.ZV27GXV9="";this.OV27GXV9="";this.GXV10="";this.ZV28GXV10="";this.OV28GXV10="";this.GXV11="";this.ZV29GXV11="";this.OV29GXV11="";this.GXV12="";this.ZV30GXV12="";this.OV30GXV12="";this.GXV13="";this.ZV31GXV13="";this.OV31GXV13="";this.GXV14=0;this.ZV32GXV14=0;this.OV32GXV14=0;this.GXV15=0;this.ZV33GXV15=0;this.OV33GXV15=0;this.GXV16=0;this.ZV34GXV16=0;this.OV34GXV16=0;this.GXV17="";this.ZV35GXV17="";this.OV35GXV17="";this.GXV1="";this.GXV2="";this.GXV3="";this.GXV4="";this.GXV5="";this.GXV6="";this.GXV7="";this.GXV8="";this.GXV9="";this.GXV10="";this.GXV11="";this.GXV12="";this.GXV13="";this.GXV14=0;this.GXV15=0;this.GXV16=0;this.GXV17="";this.A19BR_EncounterID=0;this.A61BR_Demographics_ID=0;this.A20BR_BehaviorID=0;this.Events={e133v2_client:["ENTER",!0],e143v2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"A20BR_BehaviorID",fld:"BR_BEHAVIORID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"A61BR_Demographics_ID",fld:"BR_DEMOGRAPHICS_ID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV38Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_EncounterID",fld:"vBR_ENCOUNTERID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{av:"AV13BR_Behavior",fld:"vBR_BEHAVIOR",pic:""},{av:'gx.fn.getCtrlProperty("CANCER","Visible")',ctrl:"CANCER",prop:"Visible"},{av:'gx.fn.getCtrlProperty("AGE","Visible")',ctrl:"AGE",prop:"Visible"},{av:'gx.fn.getCtrlProperty("MANOPSUSE","Visible")',ctrl:"MANOPSUSE",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{ctrl:"BR_BEHAVIOR_BR_BEHAVIORID",prop:"Visible"},{ctrl:"BR_BEHAVIOR_BR_ENCOUNTERID",prop:"Visible"},{ctrl:"BR_BEHAVIOR_BR_INFORMATION_PATIENTNO",prop:"Visible"}]];this.setVCMap("AV39Tcurrentcode","vTCURRENTCODE",0,"decimal",10,2);this.setVCMap("A19BR_EncounterID","BR_ENCOUNTERID",0,"int",18,0);this.addBCProperty("Br_behavior",["BR_Behavior_Smoking"],this.GXValidFnc[11],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_SmokingTime"],this.GXValidFnc[15],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_SmokingAmount"],this.GXValidFnc[20],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_RawSmokingAmount"],this.GXValidFnc[24],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_Achohol"],this.GXValidFnc[29],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_AchoholTime"],this.GXValidFnc[33],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_AchoholAmount"],this.GXValidFnc[38],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_RawAchoholAmount"],this.GXValidFnc[42],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_ChildNum"],this.GXValidFnc[47],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_FamilyCaHistory"],this.GXValidFnc[51],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_FamilyCancer"],this.GXValidFnc[63],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_RawMenopauseAge"],this.GXValidFnc[70],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_Menopause"],this.GXValidFnc[74],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Behavior_MenopauseAge"],this.GXValidFnc[82],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_BehaviorID"],this.GXValidFnc[86],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_EncounterID"],this.GXValidFnc[87],"AV13BR_Behavior");this.addBCProperty("Br_behavior",["BR_Information_PatientNo"],this.GXValidFnc[88],"AV13BR_Behavior");this.Initialize()})
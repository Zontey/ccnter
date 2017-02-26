alter table `Contractors` drop index `IX_WhoCreated_UserID1`
alter table `Contractors` drop column `WhoCreated_UserID`
set @columnType := (select case lower(IS_NULLABLE) when 'no' then CONCAT(column_type, ' not null ')  when 'yes' then column_type end from information_schema.columns where table_name = 'Contractors' and column_name = 'WhoCreated_UserID1');
set @sqlstmt := (select concat('alter table `Contractors` change `WhoCreated_UserID1` `WhoCreated_UserID` ' , @columnType));
prepare stmt from @sqlstmt;
execute stmt;
deallocate prepare stmt;
alter table `Contractors` add column `WhoCreatedID` int 
alter table `Contractors` modify `WhoCreated_UserID` int
CREATE index  `IX_WhoCreated_UserID` on `Contractors` (`WhoCreated_UserID` DESC) using HASH
INSERT INTO `__MigrationHistory`(
`MigrationId`, 
`ContextKey`, 
`Model`, 
`ProductVersion`) VALUES (
'201702240329520_1.', 
'CallCenterApp.Migrations.Configuration', 
0x1F8B0800000000000400CD5ADD6EDB3614BE1FB0771074396496D3A2C016D82D5227198C358911A7DDEE0A5AA26D6214A989541663D893ED628FB457D8A1FECC1FD996343B2D7A13933C1F0F8F3E9E3FF6DFBFFF19BD7B8EA9F7845341381BFBE783A1EF6116F288B0D5D8CFE4F2FB1FFC776FBFFD66741DC5CFDEA76ADD6BB50E249918FB6B29938B2010E11AC7480C6212A65CF0A51C843C0E50C48357C3E18FC1F9798001C2072CCF1B3D644C9218E73FE0E784B310273243F49647988A721C66E639AA7787622C1214E2B13F41944E309338BD4C12DFBBA4048112734C97BE8718E3124950F1E2A3C0739972B69A273080E8E326C1B06E89A8C0A5EA17DBE56D4F317CA54E116C052BA8301392C71D01CF5F9766096CF15EC6F56BB381E1AEC1C072A34E9D1B0FECC6994C512879EA7BF67617139AAAA5967507C5D7186C45CF3C63C159CD08208EFA07F31995598AC70C672043CFBC59B6A024FC196F1EF96F988D5946A9AE28A80A73C6000CCD529EE0546E1EF0D2517F7AE57B818910D8103540A37471D42993AF5FF9DE1D28841614D7DCD0CC320701FC1366384512473324E1D8F069A711CEADEBE8E1EC1A27886DD48F6A53E024DC2CDFBB45CF1F305BC9F5D8873F7DEF863CE3A81A2915F9C8085C44109269860FED75379D9D7C8F2BB0C2FDB2B265B59D1A7D24EA888E29DBC0018D3861320693FE6FC47BB9063E4ED9929FDC16BFACF924C58A160EA3F60B3E627A97C50B9C9E5CC54F9C3CC162B126C9C9F77A4429592E4FBECD659462214EBE8DA2F83118FE01652C5C2BF1EE5077E889AC7237B49379BEF78069BE447DE322086ACEFAB3BEF226E5F103A7862FD4167C9EF32C0D959A7CDF2AF8CC2B2C4D5D47C136D6EC8D401092BBC69E8192F9724147EDDE27DC54722F15685E24C2CC90107FF0343A7D98C1224C4952E44127DE6B2A2EA398D4FBBCE7407EC40EDCCE5D8CBF14828724FFA24EDEA15F4653A36B1679AD6E666109F38E834980FB2401B6834263FF3BE7C087E0AB2BADC11717D5041E0E06E7B615B4F3BA173FF7A104185DB9EE4461E58BAF166A123FCB066F007B970E41945FD03E8E029F63E95818C2C2F6B33418CAB18B09A40EDD045118C312D64EDEA48AE179B5B57B5DB4ED8EDAF2A23E88658CA02B60C5040DB0348AEDFFCCE337DC8CFAE36F2BB9A028E5AA922FD851F38D6E5192C05DD76AC072C49B9705E0F7F3EEE5515C6004A168A8926A6DEB9DC0326885AD5965B708DF90544808E36881945F9844B1B3AC91EA3BD8576DE9B2D9FD7C15332B19F5772967844E8DF516C8D69A3770409573E767C58D1C7285F3821C5194EE2DAF269C66313B5CB6ED47D44A2713509B688F9797473A4E3ED05EDE2E7D74287BAE2BAA5101B9C0C6747B6CBD16D241F5F1F66866B9A3E39933ED11B53A4887D386DB6319958E8E664C74D0ADAC660CC5CAB1F62855B1A2A354635D6E42598BD8D7AA23D7F45A4487D2C75DB45160F90BDB2B058E5BB26285EDE95AF9C122EEF4F78079D0EEEEFB9AC57659B4CAF2756B36570CFB505C17D7D5B76D13731D653BDAC11FE999B7E189F489F6787576AD63D5832FCF36336FD9157A8DECED708C3596B78FA62A1DDB19461BD232D758AD49A981EDE2A7B25CAD4E5F4DCB8CB4A5A67D9386BDAA826844F2026C2A540D57D76F9DEC6167B82E999C44D75E5253B94E78ADC4765426992D5E3CECACB358E27B60842712A98CF37633FF9D0ED4FC20FF7342499E2E542B6E11234B2C64D10EF1DF0CDE582F275FCF2B462044445B3F657C152F094499FA600BA763EFB0E1F18072B62ACAE62D56C7B781BE10CDADFF084665DECD9CA53824C5DBE0F0780F0147C2779F05FA9AA1A9EB9F7FFD6E30CE1B405F7D1A5AFC7DA1CC0E7E5F14B341DF17C5EABF1F89066E37FE48C00DF144A386D3E29AB2083F8FFD3F73E90B6FFAEB6707E0CCBB4FC16D5F7843EFAFFDC6EBD67DFF623DF093B8C863F846BBABDDDB41BA4DEBBE50564F7AC139FD420DE9A2F7D9B933BCA3D7D8BB850D64C4A9E208A22026408EB8A5C12C252C2409A2BAEE6E2ADA96E0CAA835A43D738513CC146BDD33B6D9B1553E5EEF61DDBB43C6E8D896775B9A6DFBED07DAED45920A3E76A1A26E41DD3DFDE9C67EFCCE767C137873AFFA653BF5BAD2DB8E42BB56FC8E4EFE69BAEF6EF101CCD2FE5316505C90D5164215560C8706A7EA352AB3AA586E69542DB15CDC2D9608822FBA4C2559C231613A84BC217FE3FB8468064BAE213F8AA6EC3E934926E1C8385E50E321545D917DFBE74F0CA6CEA3FBDC418B631C01D4242A7FB867EF3342A35AEF9B06F7BC0342DDBD321CAA6F2955585C6D6AA43BCE5A0295E6AB5DC6238E130A60E29ECDD113EEA31B10F7035EA170539590BB410E7F08D3ECA32B8256298A4589B195879FC0E1287E7EFB1FFB801C879B280000, 
'6.1.3-40302');
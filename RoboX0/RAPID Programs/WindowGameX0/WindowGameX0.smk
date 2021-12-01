﻿<Project>
	<PropertyGroup>
		<MainScreenIndex>0</MainScreenIndex>
	</PropertyGroup>
	<ScreenMakerVersion>21.3</ScreenMakerVersion>
	<Type>FlexPendant</Type>
	<References />
	<Controller GUID="c65b5342-d5e3-4e13-8280-bf58d95a8d67" Name="AD02-NB-A762E1" System="IRB1600_10_145" />
	<AssemblyInfo>
		<Title></Title>
		<Description>Code generated by ScreenMaker - Internal version 21.3.9648.0</Description>
		<Company></Company>
		<Product></Product>
		<Copyright></Copyright>
		<Trademark></Trademark>
		<Version>6.12.184</Version>
	</AssemblyInfo>
	<TpsViewInfo>
		<Caption>Run X0 Game</Caption>
		<MenuImageName>tpu-Operator32.png</MenuImageName>
		<TaskbarImageName>tpu-Operator32.png</TaskbarImageName>
		<StartPanelLocation>1</StartPanelLocation>
		<ViewType>1</ViewType>
		<StartupType>0</StartupType>
	</TpsViewInfo>
	<ApplicationVariables>
		<Variable Name="ULText" Value="&quot;&quot;" ValueType="ABB.Robotics.Controllers.RapidDomain.String,ABB.Robotics.Controllers.PC" />
		<Variable Name="XText" Value="&quot;X&quot;" ValueType="ABB.Robotics.Controllers.RapidDomain.String,ABB.Robotics.Controllers.PC" />
		<Variable Name="low" Value="-60" ValueType="ABB.Robotics.Controllers.RapidDomain.Dnum,ABB.Robotics.Controllers.PC" />
		<Variable Name="middle" Value="0" ValueType="ABB.Robotics.Controllers.RapidDomain.Dnum,ABB.Robotics.Controllers.PC" />
		<Variable Name="high" Value="60" ValueType="ABB.Robotics.Controllers.RapidDomain.Dnum,ABB.Robotics.Controllers.PC" />
		<Variable Name="OText" Value="&quot;O&quot;" ValueType="ABB.Robotics.Controllers.RapidDomain.String,ABB.Robotics.Controllers.PC" />
		<Variable Name="Action" Value="0" ValueType="ABB.Robotics.Controllers.RapidDomain.Dnum,ABB.Robotics.Controllers.PC" />
	</ApplicationVariables>
	<ItemGroup />
	<ItemGroup>
		<Compile Include=".\MainScreen.view">
			<Link>MainScreen.view</Link>
		</Compile>
	</ItemGroup>
	<StartVirtualFlexPendant>False</StartVirtualFlexPendant>
	<FPSDKInfo>
		<Version>6.12.184</Version>
	</FPSDKInfo>
	<WidgetInfo />
</Project>
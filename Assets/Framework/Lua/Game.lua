--主入口函数。从这里开始lua逻辑
function Main()					
	 print("GameStarted!!!!!!!!!!!!!!!!!!")	
	 LuaHelper.GetPanelManager():CreatePanel("IslandSelect")
end

--场景切换通知
function OnLevelWasLoaded(level)
	Time.timeSinceLevelLoad = 0
end
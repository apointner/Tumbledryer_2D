--Export.lua file for Tumbledryer_2D

function LuaExportStart()

	package.path  = package.path..";"..lfs.currentdir().."/LuaSocket/?.lua"
	package.cpath = package.cpath..";"..lfs.currentdir().."/LuaSocket/?.dll"

	socket = require("socket")
	IPAddress = "127.0.0.1" -- localhost
	Port = 31090

	Nutkicker_socket = socket.try(socket.connect(IPAddress, Port))
	Nutkicker_socket:setoption("tcp-nodelay",true) 

	NMC_Counter = 0
end

function LuaExportBeforeNextFrame()
end

function LuaExportAfterNextFrame()
	--Euler angles:
		local mySelf = LoGetSelfData()
		local NMC_inertial_Pitch = 	mySelf.Pitch
		local NMC_inertial_Bank = 	mySelf.Bank

	--Angular rates:
		local NMC_Omega = LoGetAngularVelocity()

	--Accelerations:
		local NMC_Accel = LoGetAccelerationUnits()

	--Let's send the data to the software:
	socket.try(Nutkicker_socket:send(string.format("%.4f, %.4f, %.4f \n",		
													NMC_inertial_Bank,			--Euler[0]
													NMC_inertial_Pitch,			--Euler[2]
													NMC_Accel.x					--Accel[0]
																							)))
end

function LuaExportStop()

	if Nutkicker_socket then 
		socket.try(Nutkicker_socket:send("exit")) -- closing the socket
		Nutkicker_socket:close()
	end
	
end

function LuaExportActivityNextEvent(t)
end

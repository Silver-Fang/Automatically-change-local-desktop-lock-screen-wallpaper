﻿Imports 本地桌面锁屏壁纸自动换.My

Enum 轮换周期 As Byte
	禁用
	分钟1
	分钟2
	分钟5
	分钟10
	分钟15
	分钟30
	小时1
	小时2
	小时3
	小时6
	小时12
	天1
	天2
	天4
	周1
	周2
	月1
End Enum

Enum 启动类型 As Byte
	用户启动
	自启动
	换桌面
	换锁屏
End Enum

Module 自动换
	Sub 自启动()

	End Sub

	Sub 换桌面()

	End Sub

	Sub 换锁屏()
		Dim 所有文件 As String() = IO.Directory.GetFiles(Settings.所有锁屏目录)
	End Sub
End Module
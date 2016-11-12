# Pipe Slice

Utilities for slicing and dicing output in command pipelines. Recommend
creating short-named copies of line.exe and word.exe (i.e. l.exe and w.exe) for
convenience.

# Usage

Usage by example:

	C:\Users\bamf>ipconfig | grep IPv4 | w -1
	192.168.0.2
	169.254.175.174

	C:\Users\bamf>dir /a/b/s "\Program Files (x86)\winnt.h" | line
	1: C:\Program Files (x86)\Microsoft Keyboard Layout Creator 1.4\inc\winnt.h
	2: C:\Program Files (x86)\Windows Kits\8.0\Include\um\winnt.h
	3: C:\Program Files (x86)\Windows Phone Kits\8.0\Include\winnt.h
	4: C:\Program Files (x86)\Windows Phone Kits\8.1\Include\winnt.h
	5: C:\Program Files (x86)\Windows Phone Silverlight Kits\8.1\Include\winnt.h

	C:\Users\bamf>dir /a/b/s "\Program Files (x86)\winnt.h" | line 2 | clip

	C:\Users\bamf>sc qc fltmgr | line
	1: [SC] QueryServiceConfig SUCCESS
	2:
	3: SERVICE_NAME: fltmgr
	4:         TYPE               : 2  FILE_SYSTEM_DRIVER
	5:         START_TYPE         : 0   BOOT_START
	6:         ERROR_CONTROL      : 3   CRITICAL
	7:         BINARY_PATH_NAME   : \SystemRoot\system32\drivers\fltmgr.sys
	8:         LOAD_ORDER_GROUP   : FSFilter Infrastructure
	9:         TAG                : 1
	10:         DISPLAY_NAME       : FltMgr
	11:         DEPENDENCIES       :
	12:         SERVICE_START_NAME :

	C:\Users\bamf>sc qc fltmgr | l 7 | w -1
	\SystemRoot\system32\drivers\fltmgr.sys


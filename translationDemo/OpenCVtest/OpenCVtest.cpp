// OpenCVtest.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"

//OpenCV测试程序用于打开指定路径下的图片
DLL_API IplImage* _stdcall test(char* fileName)
{
	IplImage* src = cvLoadImage(fileName);
	return src;
}
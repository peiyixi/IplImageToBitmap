// OpenCVtest.cpp : ���� DLL Ӧ�ó���ĵ���������
//

#include "stdafx.h"

//OpenCV���Գ������ڴ�ָ��·���µ�ͼƬ
DLL_API IplImage* _stdcall test(char* fileName)
{
	IplImage* src = cvLoadImage(fileName);
	return src;
}
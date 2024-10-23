# Ainjector 简介

由匿名开发者`Lovelymili`开发的基于C#和C++的注入器。

## 特色 

**现有功能**

1.以R3层去调用win已有的api加载dll

**下次更新功能**

1. 配合驱动从R0层注入绕过检测
2. 直接写入内存注入

## 注意事项

>> 请确保您已安装.net8 该项目基于此版本开发

>> 请确保您已把AinjictorLib.dll复制到项目根目录下 [Github]: http://github.com/Lovelymili/AinjectorLib


## 使用方式

**右键Ainjector.exe以管理员身份运行（已知进程ID情况下不需要）**

**选中自己的dll**

**双击选择要注入的进程（支持自动获取,但需要管理员权限）**

## 补充说明

本项目欢迎大佬fork和提出pr 
本项目是注入器UI部分,核心代码在AinjectorLib中,用c++编写以dll形式供给本UI调用

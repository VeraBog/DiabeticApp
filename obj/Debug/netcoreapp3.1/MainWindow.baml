   M S B A M L   `   `   `  ����F  BDiabeticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DiabeticAppDiabeticApp  5   	       DiabeticApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DiabeticApp     5   	      MaterialDesignPaper#���   5   	     MaterialDesignBody#���  5	   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFD7E6F6��6    � Offset$ 0.295Q�61   � 5      $ 	#FF6FADF1��6   $ 0.899Q�61   5       � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��250 �6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��400 �6   .+�5   
   �� $
��Bold"�6   $��Witaj Użytkowniku��6"   $
��Left=�6>   $��39��6Y   $��
281,10,0,0q�6e   $	��Top=�6y   $	��246��6�   $��20(�6�   $��2��6�   �� 5   
   $��	0,49,0,92q�6   $��/serceCukier.jpg��6#   $��1��6=   $��2��6M   $��UniformToFill=�6^   G� 5   
   -   5         G�Name$ Password��5      $
��Left=�6(   $��32��6C   $��	93,41,0,0q�6O   $	��Top=�6b   $	��219��6z   $��1��6�   ���	#FFFDFDFD$��1,1,1,1q�6�    J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!      5#      �� 5&   
   $
��Bold"�6   $��20(�6"   $��Hasło��60   $
��Left=�6@   $��34��6[   $��	162,2,0,0q�6g   $��1��6z   $	��Top=�6�   $	��238��6�   �� 5'   
   $
��Bold"�6   $��20(�6"   $��Login��60   $
��Left=�6@   $��46��6[   $��
162,94,0,0q�6g   $	��Top=�6{   $	��238��6�   �� 5(   
   -   5        	 ��Name$	 Login_button��5(      $
��Bold"�6(   $��loguj��6:   $
��Left=�6J   $��40��6e   $��
46,138,0,0q�6q   $��1��6�   $	��Top=�6�   $	��156��6�   ���	#FFF7F2F2
���   �
 � Cursor$

 Hand��6�    5)        5*      5,      �� 5-   
   -   5         ��Name$ username��5-      $
��Left=�6$   $��37��6?   $��
93,140,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��219��6�   
�������$��1,1,1,1q�6�   .��6�    5.        5/      .��50      51      �� 53   
   -   5        $	 Register_button��53   '   $��Zarejestruj��6   $
��Bold"�6_   $
��Left=�6q   $��40��6�   $��202,138,0,0q�6�   $��1��6�   $	��Top=�6�   $	��149��6�   $

 Hand��6�    54        55      57      5:      5;      
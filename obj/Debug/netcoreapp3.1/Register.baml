   M S B A M L   `   `   `  ����F  BDiabeticApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DiabeticAppDiabeticApp  5   	       DiabeticApp.Register   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DiabeticApp     5   	     � Title$  Register��5   	   $	��450��6   $	��800��6'   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFF9F9F9��6    � Offset$ 0.295Q�61   � 5      $ 	#FF898C90��6   $ 0.899Q�61   5       � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��250 �6   .+�5   
   �� $
��Bold"�6   $��Witaj Użytkowniku��6"   $��Center=�6>   $��39��6[   $��0,10,0,0q�6g   $	��Top=�6y   $	��246��6�   $��20(�6�   �� 5   
   $��400,45,33,90q�6   $��/serceCukier.jpg��6&   $��2��6@   G� 5   
   -   5         G�Name$ Password��5      $
��Left=�6(   $��32��6C   $��	93,41,0,0q�6O   $	��Top=�6b   $	��219��6z   $��1��6�   ���	#FFFDFDFD$��1,1,1,1q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $
��Bold"�6   $��20(�6"   $��Wpisz Hasło��60   $
��Left=�6F   $��34��6a   $��93,0,0,0q�6m   $��1��6   $	��Top=�6�   $	��238��6�   �� 5    
   $
��Bold"�6   $��20(�6"   $��Wpisz Login��60   $
��Left=�6F   $��46��6a   $��	93,94,0,0q�6m   $	��Top=�6�   $	��238��6�   �� 5!   
   -   5         ��Name$ Register_button��5!      $
��Bold"�6I   $��Zarejestruj��6[   $
��Left=�6q   $��40��6�   $��
93,142,0,0q�6�   $��1��6�   $	��Top=�6�   $	��157��6�   ���	#FFF7F2F2
���   �	 � Cursor$
	 Hand��6   5"        5#      5%      �� 5&   
   -   5        
 ��Name$
 Username��5&      $
��Left=�6$   $��37��6?   $��
93,140,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��219��6�   
�������$��1,1,1,1q�6�   .��6�    5'        5(      .��5)      5*      �� 5+   
   -   5        $ Register_back��5+      $
��Bold"�6E   $��Cofnij��6W   $
��Left=�6h   $��40��6�   $��255,142,0,0q�6�   $��1��6�   $	��Top=�6�   $	��157��6�   ���	#FFF7F2F2
���   �$
	 Hand��6    5,        5-      5/      52      53      
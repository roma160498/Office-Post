   M S B A M L   `   `   `  ����F  BOffice Post, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Office_PostOffice_Post  5   	       Office_Post.MainWindow   5   	   W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5   	   )localclr-namespace:Office_Post    5   	   -   5          �Name$  window��5   	    � Title$ Office Post��5   	   $��476.4��6   $��734.6��6,    � 
ResizeMode$ CanMinimize=�6:   .��5	      � ���	#FF8E8E8E J� OpacityMask 5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   � 5      $ 	#FFB18888��6   $ 0.355Q�61   5      .+�5   
   �� -   5         ��Name$ emailBox��5      $
��Left=�6$   $��28��6?   $��	83,33,0,0q�6K   	 �� TextWrapping$
	 Wrap=�6^   $	��Top=�6r   $	��267��6�   $��16(�6�   
���   �6�   �� 5   
   -   5        $ nameBox��5      $
��Left=�6#   $��28��6>   $��	83,96,0,0q�6J   $
	 Wrap=�6]   $	��Top=�6q   $	��267��6�   $��16(�6�   
���   �6�   �� 5   
   
 ��Language$
 ru-RU�66  -   5        $ 
messageBox��5   #   $
��Left=�67   $	��205��6R   $��
11,195,0,0q�6_   $
	 Wrap=�6s    �� 
AcceptsTab .  �� AcceptsReturn . $	��Top=�6�   $	��520��6�   
���   �$��14(�6�    �� 	IsEnabled . " �� VerticalScrollBarVisibility$
 Auto=�66  �� 5   
   -   5        $ titleBox��5      $
��Left=�6$   $��28��6?   $��
83,129,0,0q�6K   $
	 Wrap=�6_   $	��Top=�6s   $	��267��6�   
���   �$��18(�6�   6�   �� 5   
   -   5         ��Name$ submit��5      $��Отправить��6!   $
��Left=�65   $��28��6P   $��
14,405,0,0q�6\   $	��Top=�6p   $��123.4��6�   $��16(�6�   $��Chicago)�6�   {�.  6�   �� 5   
   -   5        $ loadEmailsListButton��5      $!��Список адресов��6/   $
��Left=�6H   $��44��6c   $��361,114,0,0q�6o   $	��Top=�6�   $	��171��6�   $��16(�6�   $��Chicago)�6�   �� 5   
   -   5         ��Name$ emailsListBox��5      $
��Left=�6)   $	��276��6D   $��
542,33,0,0q�6Q   $	��Top=�6e   $	��165��6}   
���   ����	#FFDFDFDF6�   �� 5   
   -	   5         ��Name$ label��5      $��Email:��6   $
��Left=�60   $��	12,29,0,0q�6K   $	��Top=�6^   ���	#FF8E8E8E���	#FF383737$��16(�6�   $��Chicago)�6�   $��30��6�   �� 5   
   -
   5        $ 
label_Copy��5      $��Пароль:��6$   $
��Left=�66   $��	12,64,0,0q�6Q   $	��Top=�6d   ���	#FF8E8E8E���	#FF383737$��16(�6�   $��Chicago)�6�   $��30��6�   �� 5   
   -   5        $ label_Copy1��5      $��Имя:��6%   $
��Left=�64   $��	12,97,0,0q�6O   $	��Top=�6b   ���	#FF8E8E8E���	#FF383737$��16(�6�   $��Chicago)�6�   $��30��6�   G� 5   
   -   5         G�Name$ passwordBox��5      $
��Left=�6+   $��28��6F   $��	84,64,0,0q�6R   $	��Top=�6e   $	��242��6}   $��16(�6�   
���   ����	#FF403D3D6�   �� 5   
   -   5        $ passwordVisibleTextBox��5      $
��Left=�62   $��28��6M   $��	84,64,0,0q�6Y   $
	 Wrap=�6l   $��TextBox��6�   $	��Top=�6�   $	��242��6�   
���   �$��16(�6�   $y�Hidden=�6�   .��6  5      �� 5   
   -   5        $ checkButton��5      $
��Left=�6&   $��28��6A   $��
327,64,0,0q�6M   $	��Top=�6a   $��24��6y   
�������
���   �.��5      �  J� RenderTransformOrigin$ -0.019,-1.154&�6   .+�5       �� $��eye.png��6   5!      5"      �� 5#   
   -   5         ��Name$ image��5#      $
��Left=�6   $��91��6:   $��
361,33,0,0q�6F   $	��Top=�6Z   $	��171��6r   $��rubineta.jpg��6~   �� 5$   
   -   5        $ label_Copy2��5$      $��	Тема:��6%   $
��Left=�65   $��
12,129,0,0q�6P   $	��Top=�6d   ���	#FF8E8E8E���	#FF383737$��16(�6�   $��Chicago)�6�   $��30��6�   �� 5%   
   -   5        $ label_Copy3��5%      $��Сообщение:��6%   $
��Left=�6:   $��
12,160,0,0q�6U   $	��Top=�6i   ���	#FF8E8E8E���	#FF383737$��16(�6�   $��Chicago)�6�   $��35��6�   $	��110��6�   �� 5&   
   -   5        $ AttachButton��5&      $��Прикрепить��6'   $
��Left=�6<   $��28��6W   $��407.6,405,0,0q�6c   $	��Top=�6z   $��123.4��6�   $��16(�6�   $��Chicago)�6�   6�   �� 5'   
   -   5        $ attachListBox��5'      $
��Left=�6)   $	��119��6D   $��543,314,0,-0.2q�6Q   $	��Top=�6i   $	��164��6�   
���   �6�   o� 5(   
   -   5         o�Name$
 menu��5(      $
��Left=�6   $��20��68   $��
0,0,-0.2,0q�6D   $	��Top=�6X   $	��741��6p   .@�5)      m� $��Изменить��6   .@�5*      m� -   5        $��Путь к отчету��5*      6L   m� 5+      -   5        $ ��Путь к визитке��5+      6P   �� 5,      6   m� 5-      -   5        $��
Выход��5-      6?   5.      m� 5/      $��Справка��6   .@�50      m� $��Разработчик��6   .@�51      �� $��0q�6    $	��210��6+   {�.  $��33��6I   $
��Wrap=�6U   CAProgrammer: Martseniuk Roman, BSUIR Support: roma160498@yandex.ru6�   52      m� 53      -   5        $��О программе��53      54      55      56      �� 57   
   -   5        $ signatureButton��57      $��Подпись��6*   $
��Left=�6<   $��28��6W   $��142.4,405,0,0q�6c   $	��Top=�6z   $��123.4��6�   $��16(�6�   $��Chicago)�6�   6�   �� 58   
   -   5        $ 	reportBox��58      $��
Отчет��6$   $
��Left=�64   $��28��6O   $��279.2,405,0,0q�6[   $	��Top=�6r   $��123.4��6�   $��16(�6�   $��Chicago)�6�   {�.  6�   � 59   
   -   5         �Name$ progressBar��59      $
��Left=�6+   $��28��6F   $��122,162,0,0q�6R   $	��Top=�6g   $	��409��6   ���	#FF00971C6�   5<      5=      
   M S B A M L   `   `   `  ���� F  BOffice Post, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Office_PostOffice_Post      Office_Post.MainWindow   W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    >d2http://schemas.microsoft.com/expression/blend/2008    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    )localclr-namespace:Office_Post    -     �Name$  window�� � Title$ Office Post��$��476.4��$��734.6�� � 
ResizeMode$ CanMinimize=�.��� ���	#FF8E8E8E J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q�� $ 	#FFB18888��$ 0.355Q�.+��� -    ��Name$ emailBox��$
��Left=�$��28��$��	83,33,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��267��$��16(�
���   ��� -   $ nameBox��$
��Left=�$��28��$��	83,96,0,0q�$
	 Wrap=�$	��Top=�$	��267��$��16(�
���   ��� 
 ��Language$
 ru-RU�-   $ 
messageBox��$
��Left=�$	��205��$��
11,195,0,0q�$
	 Wrap=� �� 
AcceptsTab .  �� AcceptsReturn . $	��Top=�$	��520��
���   �$��14(� �� 	IsEnabled . " �� VerticalScrollBarVisibility$
 Auto=��� -   $ titleBox��$
��Left=�$��28��$��
83,129,0,0q�$
	 Wrap=�$	��Top=�$	��267��
���   �$��18(��� -    ��Name$ submit��$��Отправить��$
��Left=�$��28��$��
14,405,0,0q�$	��Top=�$��123.4��$��16(�$��Chicago)�{�.  �� -   $ loadEmailsListButton��$!��Список адресов��$
��Left=�$��44��$��361,114,0,0q�$	��Top=�$	��171��$��16(�$��Chicago)��� -    ��Name$ emailsListBox��$
��Left=�$	��276��$��
542,33,0,0q�$	��Top=�$	��165��
���   ����	#FFDFDFDF�� -	    ��Name$ label��$��Email:��$
��Left=�$��	12,29,0,0q�$	��Top=����	#FF8E8E8E���	#FF383737$��16(�$��Chicago)�$��30���� -
   $ 
label_Copy��$��Пароль:��$
��Left=�$��	12,64,0,0q�$	��Top=����	#FF8E8E8E���	#FF383737$��16(�$��Chicago)�$��30���� -   $ label_Copy1��$��Имя:��$
��Left=�$��	12,97,0,0q�$	��Top=����	#FF8E8E8E���	#FF383737$��16(�$��Chicago)�$��30��G� -    G�Name$ passwordBox��$
��Left=�$��28��$��	84,64,0,0q�$	��Top=�$	��242��$��16(�
���   ����	#FF403D3D�� -   $ passwordVisibleTextBox��$
��Left=�$��28��$��	84,64,0,0q�$
	 Wrap=�$��TextBox��$	��Top=�$	��242��
���   �$��16(�$y�Hidden=�.���� -   $ checkButton��$
��Left=�$��28��$��
327,64,0,0q�$	��Top=�$��24��
�������
���   �.���  J� RenderTransformOrigin$ -0.019,-1.154&�.+��� $��eye.png���� -    ��Name$ image��$
��Left=�$��91��$��
361,33,0,0q�$	��Top=�$	��171��$��rubineta.jpg���� -   $ label_Copy2��$��	Тема:��$
��Left=�$��
12,129,0,0q�$	��Top=����	#FF8E8E8E���	#FF383737$��16(�$��Chicago)�$��30���� -   $ label_Copy3��$��Сообщение:��$
��Left=�$��
12,160,0,0q�$	��Top=����	#FF8E8E8E���	#FF383737$��16(�$��Chicago)�$��35��$	��110���� -   $ AttachButton��$��Прикрепить��$
��Left=�$��28��$��407.6,405,0,0q�$	��Top=�$��123.4��$��16(�$��Chicago)��� -   $ attachListBox��$
��Left=�$	��119��$��543,314,0,-0.2q�$	��Top=�$	��164��
���   �o� -    o�Name$
 menu��$
��Left=�$��20��$��
0,0,-0.2,0q�$	��Top=�$	��741��.@�m� $��Изменить��.@�m� -   $��Путь к отчету��m� -   $ ��Путь к визитке���� m� -   $��
Выход��m� $��Справка��.@�m� $��Разработчик��.@��� $��0q�$	��210��{�.  $��33��$
��Wrap=�CAProgrammer: Martseniuk Roman, BSUIR Support: roma160498@yandex.rum� -   $��О программе���� -   $ signatureButton��$��Подпись��$
��Left=�$��28��$��142.4,405,0,0q�$	��Top=�$��123.4��$��16(�$��Chicago)��� -   $ 	reportBox��$��
Отчет��$
��Left=�$��28��$��279.2,405,0,0q�$	��Top=�$��123.4��$��16(�$��Chicago)�{�.  � -    �Name$ progressBar��$
��Left=�$��28��$��122,162,0,0q�$	��Top=�$	��409�����	#FF00971C
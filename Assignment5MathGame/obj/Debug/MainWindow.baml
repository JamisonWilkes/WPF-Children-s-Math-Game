   M S B A M L   `   `   `  ����N  JAssignment5MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Assignment5MathGameAssignment5MathGame  5   	   $    Assignment5MathGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Assignment5MathGame     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$# images/welcomeSuperheroes.jpg��6    j� Stretch$ Uniform=�6E    j� TileMode$
 Tile=�6W    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ 
lblWelcome��5      $)��#Welcome to the SuperHero Math Game!��6$   $
��Left=�6R   $��	207,0,0,0q�6m   $	��Top=�6�    J� RenderTransformOrigin$ -2.242,-4.024&�6�   $
��Bold"�6�   $��20(�6�   $��2��6�   �� 5   
   -   5         ��Name$ gbUserInformation��5      $��User Information��6.   $
��Left=�6H   $	��128��6c   $��	10,51,0,0q�6p   $	��Top=�6�   $	��186��6�   $��2��6�   .��5      �� -   5        $ lblAge��5      $	��Age��6$   $
��Left=�62   $��0,64,0,0q�6M   $	��Top=�6_   $ 0.635,0.095&�6w   5      �� 5   
   -   5         ��Name$ txtUserFirstName��5      $
��Left=�6,   $��23��6G   $��	82,75,0,0q�6S   	 �� TextWrapping$
	 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��104��6�   $��2��6�   �� 5   
   -   5        $ lblLastName��5      $��	Last Name��6%   $
��Left=�69   $��
10,102,0,0q�6T   $	��Top=�6h   $��2��6�   �� 5   
   -   5        $ txtUserLastName��5      $
��Left=�6+   $��23��6F   $��
81,106,0,0q�6R   $
	 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��105��6�   $��2��6�   �� 5   
   -   5        $ 
txtUserAge��5      $
��Left=�6&   $��23��6A   $��
81,142,0,0q�6M   $
	 Wrap=�6a   $�� ��6u   $	��Top=�6~   $	��105��6�   $ 0.105,1.538&�6�   $��2��6�   �� 5   
   -   5        $ lblFirstName��5      $��
First Name��6&   $
��Left=�6;   $��	10,71,0,0q�6V   $	��Top=�6i   $ 
0.528,1.61&�6�   $��2��6�   �� 5   
   -	   5        $ 
gbGameType��5      $��	Game Type��6'   $
��Left=�6:   $	��140��6U   $��
10,219,0,0q�6b   $	��Top=�6v   $	��141��6�   $��2��6�   	� 5   
   -
   5        
 	�Name$
 
rbAddition��5      $��Addition��6*   $
��Left=�6=   $��
29,252,0,0q�6X   $	��Top=�6l   $��2��6�   	� 5   
   -   5        $
 rbSubtraction��5      $��Subtraction��6-   $
��Left=�6C   $��
29,272,0,0q�6^   $	��Top=�6r   $��2��6�   	� 5   
   -   5        $
 rbMultiplication��5      $��Multiplication��60   $
��Left=�6I   $��
29,292,0,0q�6d   $	��Top=�6x   $��2��6�   	� 5   
   -   5        $
 
rbDivision��5      $��Division��6*   $
��Left=�6=   $��
29,312,0,0q�6X   $	��Top=�6l   $��2��6�   �� 5    
   -   5         ��Name$ btnBeginGame��5       $��
Begin Game��6'   $
��Left=�6<   $��
618,66,0,0q�6W   $	��Top=�6k   $	��143��6�   $��24(�6�   $��62��6�   $ 0.462,-1.71&�6�   $��2��6�   �� 5!   
   -   5        $ lblInvalidInput��5!      $�� ��6)   $
��Left=�65   $��618,254,0,0q�6P   $	��Top=�6e   ���	#FFFBF9F9$��2��6�   �� 5"   
   -   5        $ 
lblMessage��5"      $�� ��6$   $
��Left=�6/   $��455,312,0,0q�6J   $	��Top=�6_   $ 0.596,-1.404&�6w   $��2��6�   5#      5$      
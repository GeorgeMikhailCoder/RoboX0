MODULE Module1
        CONST robtarget Target_10:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        
        CONST robtarget home:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget storeX:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget store0:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget fieldCenter:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];

        CONST num zazor := 30;
        
               
        ! Player
        ! 1 - X
        ! 2 - 0
        ! 0 - game over
        PERS string PlayerStr := "0";
        VAR robtarget curStore;
        VAR num Player:=1; 
        VAR num field{3,3}:=[
        [0,0,0],
        [0,0,0],
        [0,0,0]
        ];
        
        
        ! delta x To
        CONST num dxT :=0;
        CONST num dyT :=0;
        CONST num dzT :=0;
        
        
        CONST num ActStep:=1;
        CONST num ActEndGame:=3;
        CONST num ActWinGame:=4;
        
        PERS num Action:=1;
        
    PROC main()    
        PlayerStr:="W";
        Action :=0;
        WHILE TRUE DO
            chooseAction Action;            
        ENDWHILE
    ENDPROC
    
    PROC chooseAction(num Action)
        
        IF Action = ActStep THEN 
            moveX0;
        ELSEIF Action = ActEndGame THEN
            moveJ home, v100, z100, gripper;
        ENDIF
        
        Action := 0;
            
    ENDPROC
        
    PROC moveX0()
        VAR num i := 2 + dxT/60;
        VAR num j := 4 -  2 + dyT/60;
        
        IF field{i,j}=0 THEN
            field{i,j} := Player;
            
            IF Player=0 OR Player=1 THEN
                curStore := storeX;
                Player:=2;
                PlayerStr:="0";
            ELSE 
                curStore := store0;
                Player:=1;
                PlayerStr:="X";
            ENDIF
            
            moveCube curStore, Offs(fieldCenter, dXT,dyT, dzT);
        ENDIF
    ENDPROC
    
    PROC moveCube(robtarget pfrom, robtarget pto)
        grab(pfrom);
        stand(pto);
    ENDPROC    
    
    PROC grab(robtarget point)
        MoveJ point,v1000,z1,gripper\WObj:=Workobject_1;
        MoveL Offs(point, 0,0,zazor),v100,fine,gripper\WObj:=Workobject_1;
        PulseDO\High,do_GripClose;

        !WaitDI di_GripClosed,1;
        MoveJ point,v100,z1,gripper\WObj:=Workobject_1;
    ENDPROC
    
    PROC stand(robtarget point)
        MoveJ point,v1000,z1,gripper\WObj:=Workobject_1;
        MoveL Offs(point, 0,0,zazor),v100,fine,gripper\WObj:=Workobject_1;
        PulseDO\High,do_GripOpen;
        !WaitDI di_GripOpened,1;
        MoveJ point,v100,z1,gripper\WObj:=Workobject_1;
    ENDPROC
    PROC Path_10()
        MoveL Target_10,v1000,z100,gripper\WObj:=Workobject_1;
    ENDPROC

    
    
ENDMODULE
MODULE Module1
        CONST robtarget Target_10:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        
        CONST robtarget home:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget storeX:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget store0:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
        CONST robtarget fieldCenter:=[[199.621572681,690,-886.5],[0,0.5,0,0.866025404],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];

        CONST num zazor := 30;
        
        VAR robtarget curStore;
        
        ! Player
        ! 1 - X
        ! 2 - 0
        ! 0 - game over
        VAR num Player:=1; 
        
        ! delta x To
        CONST num dxT :=0;
        CONST num dyT :=0;
        CONST num dzT :=0;
        
        CONST num ActStep:=1;
        CONST num ActEndGame:=3;
        CONST num ActWinGame:=3;
        
        PERS num Action:=0;
        
        VAR num field{3,3}:=[
        [0,0,0],
        [0,0,0],
        [0,0,0]
        ];
            
            
        
        VAR pos curPosTo;
    
        PROC main()

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
        field{ 2 + dxT/60, 2 + dyT/60} := Player;
        
        IF Player=0 OR Player=1 THEN
            curStore := storeX;
            Player:=2;
        ELSE 
            curStore := store0;
            Player:=1;
        ENDIF
        
        moveCube curStore, Offs(fieldCenter, dXT,dyT, dzT);
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
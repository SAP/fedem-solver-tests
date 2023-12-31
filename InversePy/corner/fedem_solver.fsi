&HEADING
  modelFile = 'frc_twin.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = '<default_m.fmm>'
  weightTranslation =  2.500000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 18
  extId = 3
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 19
  extId = 4
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   3.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 21
  extId = 6
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 22
  extId = 7
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 23
  extId = 8
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   3.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 24
  extId = 9
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 40
  extId = 10
  nDOFs = 6
  ur  =  -1.000000000e+00  -0.000000000e+00   0.000000000e+00   0.000000000e+00
         -0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
         -0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 41
  extId = 11
  nDOFs = 6
  ur  =  -1.000000000e+00  -0.000000000e+00   0.000000000e+00   0.000000000e+00
         -0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
         -0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 25
  extId = 1
  extDescr = 'b_1'
  numTriads = 2
  triadIds = 16 17
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 16, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 17, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 16, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 25
  triadId = 16
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 25
  triadId = 17
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 26
  extId = 2
  extDescr = 'b_2'
  numTriads = 2
  triadIds = 17 18
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 17, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 18, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 17, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 26
  triadId = 17
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 26
  triadId = 18
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 27
  extId = 3
  extDescr = 'b_3'
  numTriads = 2
  triadIds = 18 19
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 18, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 19, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 18, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 27
  triadId = 18
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 27
  triadId = 19
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 30
  extId = 6
  extDescr = 'b_6'
  numTriads = 2
  triadIds = 21 22
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 21, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 22, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 21, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 30
  triadId = 21
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 30
  triadId = 22
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 31
  extId = 7
  extDescr = 'b_7'
  numTriads = 2
  triadIds = 22 23
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 22, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 23, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 22, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 31
  triadId = 22
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 31
  triadId = 23
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 32
  extId = 8
  extDescr = 'b_8'
  numTriads = 2
  triadIds = 23 24
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 23, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 24, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 23, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   3.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 32
  triadId = 23
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 32
  triadId = 24
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 43
  extId = 9
  extDescr = 'v_4'
  numTriads = 2
  triadIds = 40 19
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 40, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 19, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 40, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
           -1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 43
  triadId = 40
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                        -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 43
  triadId = 19
  undPosInSupElSystem =  0.000000000e+00   1.000000000e+00   0.000000000e+00   1.000000000e+00
                        -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 44
  extId = 10
  extDescr = 'h_1'
  numTriads = 2
  triadIds = 41 21
  elPropId = 215
  shadowPosAlg = 1
  refTriad1Id = 41, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 21, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 41, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  0.000000000e+00,  alpha2 =  0.000000000e+00
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 44
  triadId = 41
  undPosInSupElSystem = -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 44
  triadId = 21
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

! Axial spring
&SPRING_BASE
  id = 45
  extId = 1
  extDescr = 'Spr_1'
  l0 =  2.828427125e+00, l1 = 0.0, lengthEngineId = 0
  s0 =  1.000000000e+05, s1 = 0.0, stiffFuncId = 0
/

! Axial spring
&SPRING_ELEMENT
  id = 45
  extId = 1
  extDescr = 'Spr_1'
  springBaseId = 45
  triadIDs = 18 22
/

! Axial damper
&DAMPER
  id = 70
  extId = 1
  extDescr = 'Dmp_1'
  triad1Id = 18
  triad2Id = 22
/

&MASTERSLAVEJOINT
  id = 42
  extId = 1
  extDescr = 'j1'
  InitPosInGlobal = -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
                     0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
  type         = 1
  nJointVars   = 1
  JointVarDefs = 6 1
  JVarInitVal  =  -0.000000000e+00
  JVarInitVel  =   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00
  springId     = 0
  damperId     = 0
  slaveId  = 41
  masterId = 40
/

'Beam properties
&ELEMENT_PROPERTY
  id = 215
  extId = 1
  extDescr = 'd_30mm'
  geometry =   2.159844949e-02   2.058602217e-04   2.058602217e-04   4.117204435e-04 2.000000 2.000000 0.000000 0.000000
  material =   7.850000000e+03   2.100000000e+11   8.139534884e+10
/

&SENSOR
  id = 13617
  extId = 2
  extDescr = 'Sensor on Axial spring [1]'
  type = 'SPRING_AXIAL'
  springId  = 45
  dofEntity = 'DEFL'
/

&SENSOR
  id = 9421
  extId = 1
  extDescr = 'Sensor on Triad [9]'
  type = 'TRIAD'
  triad1Id  = 24
  dof       = 2
  dofEntity = 'POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 17576
  extId = 1
  extDescr = 'Relative sensor between Triad [7] and Triad [3]'
  type = 'RELATIVE_TRIAD'
  triad1Id  = 22
  triad2Id  = 18
  dof       = 0
  dofEntity = 'REL_POS'
  dofSystem = 'GLOBAL'
/

&SENSOR
  id = 13618
  extId = 2
  extDescr = 'Sensor on Axial spring [1]'
  type = 'SPRING_AXIAL'
  springId  = 45
  dofEntity = 'FORCE'
/

&ENGINE
  id = 113
  extId = 2
  extDescr = 'Deflection'
  nArg = 1, argSensorId = 13617
/

&ENGINE
  id = 115
  extId = 3
  extDescr = 'end_ty'
  nArg = 1, argSensorId = 9421
/

&ENGINE
  id = 174
  extId = 4
  extDescr = 'relDis'
  nArg = 1, argSensorId = 17576
/

&ENGINE
  id = 196
  extId = 5
  extDescr = 'sprFrc'
  nArg = 1, argSensorId = 13618
/


&HEADING
  modelFile = 'tz_twin_step10000.fmm'
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
  id = 17
  extId = 1
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 18
  extId = 2
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 21
  extId = 3
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 22
  extId = 4
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 25
  extId = 5
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 26
  extId = 6
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 28
  extId = 7
  extDescr = 'bottom'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 29
  extId = 8
  extDescr = 'end'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 47
  extId = 9
  nDOFs = 6
  ur  =   0.000000000e+00  -7.071067800e-01   7.071067800e-01   9.999998800e-01
          0.000000000e+00   7.071067800e-01   7.071067800e-01   3.000000000e+00
         -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 51
  extId = 11
  nDOFs = 6
  ur  =   0.000000000e+00  -7.071067800e-01   7.071067800e-01   9.999998800e-01
          0.000000000e+00   7.071067800e-01   7.071067800e-01   3.000000000e+00
         -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 30
  extId = 1
  extDescr = 'v1'
  numTriads = 2
  triadIds = 28 17
  elPropId = 136
  shadowPosAlg = 1
  refTriad1Id = 28, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 17, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 28, offset3 =  0.000000000e+00   2.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 30
  triadId = 28
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 30
  triadId = 17
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   2.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 31
  extId = 2
  extDescr = 'v2'
  numTriads = 2
  triadIds = 17 21
  elPropId = 136
  shadowPosAlg = 1
  refTriad1Id = 17, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 21, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 17, offset3 =  0.000000000e+00   2.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 31
  triadId = 17
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 31
  triadId = 21
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   2.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 32
  extId = 3
  extDescr = 'h1'
  numTriads = 2
  triadIds = 22 25
  elPropId = 136
  shadowPosAlg = 1
  refTriad1Id = 22, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 25, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 22, offset3 =  0.000000000e+00   2.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 32
  triadId = 22
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 32
  triadId = 25
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 33
  extId = 4
  extDescr = 'h2'
  numTriads = 2
  triadIds = 25 29
  elPropId = 136
  shadowPosAlg = 1
  refTriad1Id = 25, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 29, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 25, offset3 =  0.000000000e+00   2.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 33
  triadId = 25
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 33
  triadId = 29
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 48
  extId = 6
  extDescr = 's1'
  numTriads = 2
  triadIds = 47 26
  elPropId = 136
  shadowPosAlg = 1
  refTriad1Id = 47, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 26, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 47, offset3 =  0.000000000e+00   1.414213647e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  7.071068236e-01  -7.071067388e-01  -0.000000000e+00   9.999998800e-01
            7.071067388e-01   7.071068236e-01  -0.000000000e+00   3.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 48
  triadId = 47
  undPosInSupElSystem =  0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
                        -5.999999642e-08   9.999999983e-01   0.000000000e+00   0.000000000e+00
                         9.999999983e-01   5.999999642e-08   0.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 48
  triadId = 26
  undPosInSupElSystem =  7.071068236e-01  -7.071067388e-01   0.000000000e+00   1.414213647e+00
                         7.071067388e-01   7.071068236e-01   0.000000000e+00   2.220446049e-16
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 53
  extId = 7
  extDescr = 's2'
  numTriads = 2
  triadIds = 51 18
  elPropId = 136
  shadowPosAlg = 1
  refTriad1Id = 51, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 18, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 51, offset3 =  0.000000000e+00   1.414213478e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos = -7.071067388e-01   7.071068236e-01   0.000000000e+00   9.999998800e-01
           -7.071068236e-01  -7.071067388e-01   0.000000000e+00   3.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 53
  triadId = 51
  undPosInSupElSystem = -0.000000000e+00   0.000000000e+00  -1.000000000e+00   0.000000000e+00
                        -6.000000358e-08  -9.999999983e-01   0.000000000e+00   0.000000000e+00
                        -9.999999983e-01   6.000000358e-08   0.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 53
  triadId = 18
  undPosInSupElSystem = -7.071067388e-01   7.071068236e-01   0.000000000e+00   1.414213478e+00
                        -7.071068236e-01  -7.071067388e-01   0.000000000e+00   2.220446049e-16
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

! Joint spring
&SPRING_BASE
  id = 55
  extId = 1
  l0 =  0.000000000e+00, l1 = 0.0, lengthEngineId = 0
  s0 =  1.000000000e+02, s1 = 0.0, stiffFuncId = 0
/

&MASTERSLAVEJOINT
  id = 19
  extId = 1
  extDescr = 'v_middle'
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  type         = 1
  nJointVars   = 1
  JointVarDefs = 6 1
  JVarInitVal  =   0.000000000e+00
  JVarInitVel  =   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00
  springId     = 0
  damperId     = 0
  slaveId  = 18
  masterId = 17
/

&MASTERSLAVEJOINT
  id = 23
  extId = 2
  extDescr = 'edge'
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  type         = 1
  nJointVars   = 1
  JointVarDefs = 6 1
  JVarInitVal  =   0.000000000e+00
  JVarInitVel  =   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00
  springId     = 0
  damperId     = 0
  slaveId  = 22
  masterId = 21
/

&MASTERSLAVEJOINT
  id = 27
  extId = 3
  extDescr = 'h_middle'
  InitPosInGlobal =  1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
                     0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
                     0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  type         = 1
  nJointVars   = 1
  JointVarDefs = 6 1
  JVarInitVal  =   0.000000000e+00
  JVarInitVel  =   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00
  springId     = 0
  damperId     = 0
  slaveId  = 26
  masterId = 25
/

&MASTERSLAVEJOINT
  id = 52
  extId = 4
  extDescr = 'strut'
  InitPosInGlobal =  0.000000000e+00  -7.071067800e-01   7.071067800e-01   9.999998800e-01
                     0.000000000e+00   7.071067800e-01   7.071067800e-01   3.000000000e+00
                    -1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
  type         = 1
  nJointVars   = 2
  JointVarDefs = 6 1   3 1
  JVarInitVal  =   0.000000000e+00   0.000000000e+00
  JVarInitVel  =   0.000000000e+00   0.000000000e+00
  JVarInitAcc  =   0.000000000e+00   0.000000000e+00
  springId     = 0 55
  damperId     = 0 0
  BC = 0 1
  slaveId  = 51
  masterId = 47
/

'Beam properties
&ELEMENT_PROPERTY
  id = 136
  extId = 1
  extDescr = 'tube_30mm'
  geometry =   2.159844949e-02   2.058602217e-04   2.058602217e-04   4.117204435e-04 2.000000 2.000000 0.000000 0.000000
  material =   7.850000000e+03   2.100000000e+11   8.139534884e+10
/

&SENSOR
  id = 84312
  extId = 3
  extDescr = 'Sensor on Revolute joint [4]'
  type = 'SPRING_JOINT'
  springId  = 55
  dofEntity = 'FORCE'
/

&ENGINE
  id = 112
  extId = 1
  extDescr = 'strut_Fz'
  nArg = 1, argSensorId = 84312
/


&HEADING
  modelFile = 'C:\Users\I331884\Fedem-src\solverTests.git\FrequencyDomain\SpringDamper\sd.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = 'The model is a 2D cantilever beam consisting of 8 Beam elements'
  weightTranslation =  2.500000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  extDescr = 'triad_16_start'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  extDescr = 'triad_17'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 112
  extId = 3
  extDescr = 'triad_112'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 113
  extId = 4
  extDescr = 'triad_113'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   3.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 114
  extId = 5
  extDescr = 'triad_114_end'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 288
  extId = 6
  extDescr = 'triad_288'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 290
  extId = 7
  extDescr = 'triad_290'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.500000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 292
  extId = 8
  extDescr = 'triad_292'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.500000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 294
  extId = 9
  extDescr = 'triad_294'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   3.500000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 377
  extId = 10
  extDescr = 'spring_start'
  nDOFs = 0
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -1.000000000e+00
/

&TRIAD
  id = 379
  extId = 11
  extDescr = 'damper_start'
  nDOFs = 0
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00  -5.000000000e-01
/

&SUP_EL
  id = 19
  extId = 1
  extDescr = 'first'
  numTriads = 2
  triadIds = 16 288
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 19
  triadId = 16
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 19
  triadId = 288
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 115
  extId = 2
  extDescr = 'third'
  numTriads = 2
  triadIds = 17 290
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 115
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 115
  triadId = 290
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 116
  extId = 3
  extDescr = 'fifth'
  numTriads = 2
  triadIds = 112 292
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 116
  triadId = 112
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 116
  triadId = 292
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 117
  extId = 4
  extDescr = 'seventh'
  numTriads = 2
  triadIds = 113 294
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   3.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 117
  triadId = 113
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 117
  triadId = 294
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 289
  extId = 5
  extDescr = 'second'
  numTriads = 2
  triadIds = 288 17
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   5.000000000e-01
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 289
  triadId = 288
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 289
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 291
  extId = 6
  extDescr = 'fourth'
  numTriads = 2
  triadIds = 290 112
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.500000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 291
  triadId = 290
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 291
  triadId = 112
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 293
  extId = 7
  extDescr = 'sixth'
  numTriads = 2
  triadIds = 292 113
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.500000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 293
  triadId = 292
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 293
  triadId = 113
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 295
  extId = 8
  extDescr = 'eigth'
  numTriads = 2
  triadIds = 294 114
  elPropId = 441
  shadowPosAlg = 2
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   3.500000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 295
  triadId = 294
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 295
  triadId = 114
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e-01
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

! Axial spring
&SPRING_BASE
  id = 378
  extId = 1
  extDescr = 'spring_1'
  l0 =   1.000000000e+00, l1 =   0.000000000e+00, lengthEngineId = 0
  s0 =   5.000000000e+04, s1 =   0.000000000e+00, stiffFuncId = 0
/

! Axial spring
&SPRING_ELEMENT
  id = 378
  extId = 1
  extDescr = 'spring_1'
  springBaseId = 378
  triadIDs = 377 114
/

! Axial damper
&DAMPER
  id = 380
  extId = 1
  extDescr = 'damper_1'
  triad1Id = 379
  triad2Id = 112
  d0 =   1.000000000e-02, d1 =   0.000000000e+00,  coeffFuncId = 0
/

'Beam properties
&ELEMENT_PROPERTY
  id = 441
  extId = 1
  extDescr = 'dia_200mm'
  geometry = 3.141592654e-02   7.853981634e-05   7.853981634e-05   1.570796327e-04  0.5 0.5
  material = 7.850000000e+03   2.100000000e+11   8.076923077e+10
/

&LOAD
  id = 415
  extId = 6
  triadId = 294
  lDof = 3
  loadType = 1
  f0 = 0.0, f1 = 1.0, loadEngineId = 344
/

&SENSOR
  id = 382
  extId = 1
  type = 'TIME'
/

&ENGINE
  id = 344
  extId = 2
  extDescr = 'sweep'
  functionId = 381
  nArg = 1, argSensorId = 382
/

&FUNCTION
  id = 381
  extId = 1
  type = 'MATH_EXPRESSION'
  expression = '20000*sin(2*PI*x*x/3)'
  nArg = 1
/

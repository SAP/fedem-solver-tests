&HEADING
  modelFile = 'C:\Users\I331884\Fedem-src\solverTests.git\FrequencyDomain\Frame\Frame.fmm'
  version = 3.0
/

&MECHANISM
  id = 1
  extId = 1
  extDescr = 'The model is a structural frame consisting of 10 beam elements in a L-shape with 2 supports.'
  weightTranslation =  2.000000000e-01
  weightRotation    =  1.000000000e+00
  weightGeneralized =  1.000000000e+00
/

&TRIAD
  id = 16
  extId = 1
  extDescr = 't16_start'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 0 0 0 0 0 0
/

&TRIAD
  id = 17
  extId = 2
  extDescr = 't17_corner'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 18
  extId = 3
  extDescr = 't18_end'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
  BC = 1 1 0 1 1 1
/

&TRIAD
  id = 23
  extId = 4
  extDescr = 't23_v'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 24
  extId = 5
  extDescr = 't24_v'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 26
  extId = 6
  extDescr = 't26_v'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   3.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 28
  extId = 7
  extDescr = 't28_v'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 31
  extId = 8
  extDescr = 't31_h'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 32
  extId = 9
  extDescr = 't32_h'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   2.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 34
  extId = 10
  extDescr = 't34_h'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   3.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&TRIAD
  id = 36
  extId = 11
  extDescr = 't36_h'
  nDOFs = 6
  ur  =   1.000000000e+00   0.000000000e+00   0.000000000e+00   4.000000000e+00
          0.000000000e+00   1.000000000e+00   0.000000000e+00   5.000000000e+00
          0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 21
  extId = 1
  extDescr = 'v1'
  numTriads = 2
  triadIds = 16 23
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 16, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 23, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 16, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 21
  triadId = 16
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 21
  triadId = 23
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 22
  extId = 2
  extDescr = 'h1'
  numTriads = 2
  triadIds = 17 31
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 17, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 31, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 17, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   0.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   5.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 22
  triadId = 17
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 22
  triadId = 31
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 25
  extId = 3
  extDescr = 'v2'
  numTriads = 2
  triadIds = 23 24
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 23, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 24, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 23, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 25
  triadId = 23
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 25
  triadId = 24
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 27
  extId = 4
  extDescr = 'v3'
  numTriads = 2
  triadIds = 24 26
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 24, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 26, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 24, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 27
  triadId = 24
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 27
  triadId = 26
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 29
  extId = 5
  extDescr = 'v4'
  numTriads = 2
  triadIds = 26 28
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 26, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 28, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 26, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   3.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 29
  triadId = 26
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   0.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 29
  triadId = 28
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 30
  extId = 6
  extDescr = 'v5'
  numTriads = 2
  triadIds = 28 17
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 28, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 17, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 28, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  0.000000000e+00  -1.000000000e+00  -0.000000000e+00   0.000000000e+00
            1.000000000e+00   0.000000000e+00  -0.000000000e+00   4.000000000e+00
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
  undPosInSupElSystem =  0.000000000e+00  -1.000000000e+00   0.000000000e+00   1.000000000e+00
                         1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 33
  extId = 7
  extDescr = 'h2'
  numTriads = 2
  triadIds = 31 32
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 31, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 32, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 31, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   1.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   5.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 33
  triadId = 31
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 33
  triadId = 32
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 35
  extId = 8
  extDescr = 'h3'
  numTriads = 2
  triadIds = 32 34
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 32, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 34, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 32, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   2.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   5.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 35
  triadId = 32
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 35
  triadId = 34
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 37
  extId = 9
  extDescr = 'h4'
  numTriads = 2
  triadIds = 34 36
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 34, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 36, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 34, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   3.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   5.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 37
  triadId = 34
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 37
  triadId = 36
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

&SUP_EL
  id = 38
  extId = 10
  extDescr = 'h5'
  numTriads = 2
  triadIds = 36 18
  elPropId = 84
  shadowPosAlg = 1
  refTriad1Id = 36, offset1 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad2Id = 18, offset2 =  0.000000000e+00   0.000000000e+00   0.000000000e+00
  refTriad3Id = 36, offset3 =  0.000000000e+00   1.000000000e+00   0.000000000e+00
  massCorrFlag = 0
  stiffScale =  1.000000000e+00
  massScale  =  1.000000000e+00
  alpha1 =  1.697000000e-01,  alpha2 =  9.400000000e-03
  supPos =  1.000000000e+00  -0.000000000e+00  -0.000000000e+00   4.000000000e+00
            0.000000000e+00   1.000000000e+00  -0.000000000e+00   5.000000000e+00
            0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 38
  triadId = 36
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/
&TRIAD_UNDPOS
  supElId = 38
  triadId = 18
  undPosInSupElSystem =  1.000000000e+00   0.000000000e+00   0.000000000e+00   1.000000000e+00
                         0.000000000e+00   1.000000000e+00   0.000000000e+00   0.000000000e+00
                         0.000000000e+00   0.000000000e+00   1.000000000e+00   0.000000000e+00
/

'Beam properties
&ELEMENT_PROPERTY
  id = 84
  extId = 1
  extDescr = 'Section_0.2m'
  geometry = 7.068583471e-02   1.811324514e-03   1.811324514e-03   3.622649029e-03  0.5 0.5
  material = 7.850000000e+03   2.100000000e+11   8.139534884e+10
/

&LOAD
  id = 42
  extId = 1
  triadId = 17
  lDof = 1
  loadType = 1
  f0 = 0.0, f1 = 1.0, loadEngineId = 45
/

&LOAD
  id = 66
  extId = 1
  triadId = 18
  lDof = 2
  loadType = 2
  f0 = 0.0, f1 = 1.0, loadEngineId = 40
/

&SENSOR
  id = 39
  extId = 1
  type = 'TIME'
/

&ENGINE
  id = 40
  extId = 1
  extDescr = 'sine'
  functionId = 47
  nArg = 1, argSensorId = 39
/

&ENGINE
  id = 45
  extId = 2
  extDescr = 'trig'
  functionId = 46
  nArg = 1, argSensorId = 39
/

&FUNCTION
  id = 47
  extId = 1
  type = 'SINUSOIDAL'
  realDataSize = 5
  realData =   2.000000e+01   0.000000e+00   5.000000e-02   0.000000e+00
               0.000000e+00
/

&FUNCTION
  id = 46
  extId = 1
  type = 'MATH_EXPRESSION'
  expression = '1000000.0*sin(2.0*PI*x)'
  nArg = 1
/
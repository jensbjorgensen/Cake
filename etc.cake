CAKE_CC="cake-g++-quiet -I ."

CAKE_CXXFLAGS="-fPIC -g -Wall"
CAKE_LINKFLAGS="-fPIC -B/usr/lib/binutils-2.18/ -Wall -Werror"
CAKE_TESTPREFIX="timeout 300 valgrind --quiet --error-exitcode=1"
CAKE_POSTPREFIX="timeout 60"

CAKE_DEBUG_CC="$CAKE_CC"
CAKE_DEBUG_CXXFLAGS="$CAKE_CXXFLAGS"
CAKE_DEBUG_LINKFLAGS="$CAKE_LINKFLAGS"
CAKE_DEBUG_TESTPREFIX="valgrind --quiet --error-exitcode=1"
CAKE_DEBUG_POSTPREFIX="timeout 60"

CAKE_RELEASE_CC="$CAKE_CC"
CAKE_RELEASE_CXXFLAGS="-fPIC -O3 -DNDEBUG -Wall -finline-functions -Wno-inline"
CAKE_RELEASE_LINKFLAGS="-O3 -Wall"
CAKE_RELEASE_TESTPREFIX=""
CAKE_RELEASE_POSTPREFIX="timeout 60"

CAKE_PROFILE_CC="$CAKE_CC"
CAKE_PROFILE_CXXFLAGS="$CAKE_RELEASE_CXXFLAGS -pg -g"
CAKE_PROFILE_LINKFLAGS="-O3 -Wall -pg -g"
CAKE_PROFILE_TESTPREFIX=""
CAKE_PROFILE_POSTPREFIX="timeout 60"

CAKE_COVERAGE_CC="g++ -I ."
CAKE_COVERAGE_CXXFLAGS="-fPIC -O0 -fno-inline -Wall -g -fprofile-arcs -ftest-coverage"
CAKE_COVERAGE_LINKFLAGS="-fPIC -O0 -fno-inline -Wall -g -fprofile-arcs -ftest-coverage"
CAKE_COVERAGE_TESTPREFIX="valgrind --quiet --error-exitcode=1"
CAKE_COVERAGE_POSTPREFIX="timeout 60"

CAKE_ZPROFILE_CC="$CAKE_CC"
CAKE_ZPROFILE_CXXFLAGS="$CAKE_PROFILE_CXXFLAGS -DZPROFILE"
CAKE_ZPROFILE_LINKFLAGS="$CAKE_PROFILE_LINKFLAGS -lzprofile"
CAKE_ZPROFILE_TESTPREFIX=""
CAKE_ZPROFILE_POSTPREFIX="timeout 60"

CAKE_GCC44_CC="ccache g++44 -I . -isystem /usr/include/boost-1.42.0/ -std=gnu++0x -L/usr/lib64/boost-1.42.0/"
CAKE_GCC44_ID="GCC44"
CAKE_GCC44_CXXFLAGS="$CAKE_CXXFLAGS"
CAKE_GCC44_LINKFLAGS="$CAKE_LINKFLAGS"
CAKE_GCC44_TESTPREFIX="$CAKE_DEBUG_TESTPREFIX"
CAKE_GCC44_POSTPREFIX="timeout 60"

CAKE_GCC44_PROFILE_CC="$CAKE_GCC44_CC"
CAKE_GCC44_PROFILE_ID="$CAKE_GCC44_ID"
CAKE_GCC44_PROFILE_CXXFLAGS="$CAKE_PROFILE_CXXFLAGS"
CAKE_GCC44_PROFILE_LINKFLAGS="$CAKE_PROFILE_LINKFLAGS"
CAKE_GCC44_PROFILE_TESTPREFIX=""
CAKE_GCC44_PROFILE_POSTPREFIX="timeout 60"

CAKE_GCC44_RELEASE_CC="$CAKE_GCC44_CC"
CAKE_GCC44_RELEASE_ID="$CAKE_GCC44_ID"
CAKE_GCC44_RELEASE_CXXFLAGS="$CAKE_RELEASE_CXXFLAGS -fno-strict-aliasing"
CAKE_GCC44_RELEASE_LINKFLAGS="$CAKE_RELEASE_LINKFLAGS -fno-strict-aliasing"
CAKE_GCC44_RELEASE_TESTPREFIX=""
CAKE_GCC44_RELEASE_POSTPREFIX="timeout 60"

CAKE_GCC44_COVERAGE_CC="g++44 -I . -isystem /usr/include/boost-1.42.0/ -std=gnu++0x -L/usr/lib64/boost-1.42.0/"
CAKE_GCC44_COVERAGE_ID="$CAKE_GCC44_ID"
CAKE_GCC44_COVERAGE_CXXFLAGS="$CAKE_COVERAGE_CXXFLAGS"
CAKE_GCC44_COVERAGE_LINKFLAGS="$CAKE_COVERAGE_LINKFLAGS"
CAKE_GCC44_COVERAGE_TESTPREFIX="$CAKE_COVERAGE_TESTPREFIX"
CAKE_GCC44_COVERAGE_POSTPREFIX="timeout 60"

CAKE_GCC46_CC="ccache /opt/scripts/g++46 -I . -isystem /usr/include/boost-1.42.0/ -L/usr/lib64/boost-1.42.0/ -Wl,-R/usr/lib64/boost-1.42.0 -isystem /usr/include/"
CAKE_GCC46_ID="GCC46"
CAKE_GCC46_CXXFLAGS="$CAKE_CXXFLAGS"
CAKE_GCC46_LINKFLAGS="$CAKE_LINKFLAGS "
CAKE_GCC46_TESTPREFIX="$CAKE_DEBUG_TESTPREFIX"
CAKE_GCC46_POSTPREFIX="timeout 60"

CAKE_GCC46_PROFILE_CC="$CAKE_GCC46_CC"
CAKE_GCC46_PROFILE_ID="$CAKE_GCC46_ID"
CAKE_GCC46_PROFILE_CXXFLAGS="$CAKE_PROFILE_CXXFLAGS"
CAKE_GCC46_PROFILE_LINKFLAGS="$CAKE_PROFILE_LINKFLAGS"
CAKE_GCC46_PROFILE_TESTPREFIX=""
CAKE_GCC46_PROFILE_POSTPREFIX="timeout 60"

CAKE_GCC46_RELEASE_CC="$CAKE_GCC46_CC"
CAKE_GCC46_RELEASE_ID="$CAKE_GCC46_ID"
CAKE_GCC46_RELEASE_CXXFLAGS="$CAKE_RELEASE_CXXFLAGS -fno-strict-aliasing"
CAKE_GCC46_RELEASE_LINKFLAGS="$CAKE_RELEASE_LINKFLAGS -fno-strict-aliasing"
CAKE_GCC46_RELEASE_TESTPREFIX=""
CAKE_GCC46_RELEASE_POSTPREFIX="timeout 60"

CAKE_GCC46_COVERAGE_CC="$CAKE_GCC46_CC"
CAKE_GCC46_COVERAGE_ID="$CAKE_GCC46_ID"
CAKE_GCC46_COVERAGE_CXXFLAGS="$CAKE_COVERAGE_CXXFLAGS"
CAKE_GCC46_COVERAGE_LINKFLAGS="$CAKE_COVERAGE_LINKFLAGS"
CAKE_GCC46_COVERAGE_TESTPREFIX="$CAKE_COVERAGE_TESTPREFIX"
CAKE_GCC46_COVERAGE_POSTPREFIX="timeout 60"


CAKE_CC="ccache cake-g++-quiet -I ."

CAKE_CXXFLAGS="-fPIC -g -Wall -Werror"
CAKE_LINKFLAGS="-fPIC -B/usr/lib/binutils-2.18/ -Wall -Werror"

CAKE_DEBUG_CC="$CAKE_CC"
CAKE_DEBUG_CXXFLAGS="$CAKE_CXXFLAGS"
CAKE_DEBUG_LINKFLAGS="$CAKE_LINKFLAGS"

CAKE_RELEASE_CC="$CAKE_CC"
CAKE_RELEASE_CXXFLAGS="-fPIC -O3 -DNDEBUG -Wall -finline-functions -Wno-inline -Werror"
CAKE_RELEASE_LINKFLAGS="-O3 -Wall -Werror"

CAKE_PROFILE_CC="$CAKE_CC"
CAKE_PROFILE_CXXFLAGS="$CAKE_RELEASE_CXXFLAGS -pg -g"
CAKE_PROFILE_LINKFLAGS="-O3 -Wall -pg -g -Werror"

CAKE_COVERAGE_CC="cake-g++-quiet -I ."
CAKE_COVERAGE_CXXFLAGS="-fPIC -O0 -fno-inline -Wall -g -fprofile-arcs -ftest-coverage -Werror"
CAKE_COVERAGE_LINKFLAGS="-fPIC -O0 -fno-inline -Wall -g -fprofile-arcs -ftest-coverag -Werrore"

CAKE_ZPROFILE_CC="$CAKE_CC"
CAKE_ZPROFILE_CXXFLAGS="$CAKE_PROFILE_CXXFLAGS -Dzprofile -Werror"
CAKE_ZPROFILE_LINKFLAGS="$CAKE_RELEASE_LINKFLAGS -lzprofile -Werror"


CAKE_GCC44_CC="ccache g++44 -I . -isystem /usr/include/boost-1.42.0/ -std=gnu++0x -L/usr/lib64/boost-1.42.0/"
CAKE_GCC44_CXXFLAGS="$CAKE_CXXFLAGS"
CAKE_GCC44_LINKFLAGS="$CAKE_LINKFLAGS"

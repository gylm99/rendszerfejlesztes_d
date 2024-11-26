<script>
import { ref } from "vue";
import { authState, signOut } from "../auth/auth";

export default {
  setup() {
    const dropdownOpen = ref(false);

    function toggleDropdown() {
      dropdownOpen.value = !dropdownOpen.value;
    }

    return {
      auth: authState,
      dropdownOpen,
      toggleDropdown,
      signOut,
    };
  },
  name: "NavBar"
};
</script>

<template>
      <!-- Header -->
      <header class="bg-white shadow py-4 px-6 flex items-center justify-between">
        <!-- Search Bar -->
        <div class="flex items-center w-full max-w-md">
          <input
            type="text"
            placeholder="Search..."
            class="w-full px-4 py-2 border rounded-md border-green-300 focus:outline-none focus:border-green-800"
          />
          <button
            class="bg-green-600 text-white px-4 py-2 rounded-md hover:bg-green-900 focus:outline-none mx-5"
          >
            Filter
          </button>
        </div>
  
        <!-- Logo -->
        <router-link to="/">
          <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
        </router-link>
  
        <!-- Navbar Buttons -->
        <div class="flex space-x-4">
          <template v-if="!auth.user">
            <!-- Sign In / Register Buttons -->
            <router-link to="/signin">
              <button
                @click="isSignInActive = true"
                class="px-4 py-2 bg-gray-300 text-gray-800 rounded-md hover:bg-gray-400 hover:text-white focus:outline-none"
              >
                Sign In
              </button>
            </router-link>
            <router-link to="/signup">
              <button
                class="px-4 py-2 bg-green-600 text-white rounded-md hover:bg-green-900 focus:outline-none"
              >
                Register
              </button>
            </router-link>
          </template>
          <template v-else>
            <!-- User Dropdown Menu -->
            <div class="relative">
              <button
                @click="toggleDropdown"
                class="flex items-center px-4 py-2 bg-green-600 text-white rounded-md hover:bg-green-900 focus:outline-none"
              >
<svg width="20px" height="20px" class="fill-white mx-2" viewBox="0 0 20 20" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
    <g id="Page-1" >
        <g id="Dribbble-Light-Preview" transform="translate(-140.000000, -2159.000000)" fill="white">
            <g id="icons" transform="translate(56.000000, 160.000000)">
                <path d="M100.562548,2016.99998 L87.4381713,2016.99998 C86.7317804,2016.99998 86.2101535,2016.30298 86.4765813,2015.66198 C87.7127655,2012.69798 90.6169306,2010.99998 93.9998492,2010.99998 C97.3837885,2010.99998 100.287954,2012.69798 101.524138,2015.66198 C101.790566,2016.30298 101.268939,2016.99998 100.562548,2016.99998 M89.9166645,2004.99998 C89.9166645,2002.79398 91.7489936,2000.99998 93.9998492,2000.99998 C96.2517256,2000.99998 98.0830339,2002.79398 98.0830339,2004.99998 C98.0830339,2007.20598 96.2517256,2008.99998 93.9998492,2008.99998 C91.7489936,2008.99998 89.9166645,2007.20598 89.9166645,2004.99998 M103.955674,2016.63598 C103.213556,2013.27698 100.892265,2010.79798 97.837022,2009.67298 C99.4560048,2008.39598 100.400241,2006.33098 100.053171,2004.06998 C99.6509769,2001.44698 97.4235996,1999.34798 94.7348224,1999.04198 C91.0232075,1998.61898 87.8750721,2001.44898 87.8750721,2004.99998 C87.8750721,2006.88998 88.7692896,2008.57398 90.1636971,2009.67298 C87.1074334,2010.79798 84.7871636,2013.27698 84.044024,2016.63598 C83.7745338,2017.85698 84.7789973,2018.99998 86.0539717,2018.99998 L101.945727,2018.99998 C103.221722,2018.99998 104.226185,2017.85698 103.955674,2016.63598" id="profile_round-[#1342]">

</path>
            </g>
        </g>
    </g>
</svg>
                {{ auth.user.username }}
              </button>
  
              <!-- Dropdown Menu -->
              <div
                v-if="dropdownOpen"
                class="absolute right-0 mt-2 w-48 bg-gray-100 rounded-md shadow-lg z-50"
              >
                <router-link
                  to="/messages"
                  class="block px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Messages
                </router-link>
                <router-link
                  to="/itemupload"
                  class="block px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Upload advertisement
                </router-link>
                <router-link
                  to="/profile"
                  class="block px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Profile
                </router-link>
                <button
                  @click="signOut"
                  class="w-full text-left px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Sign Out
                </button>
              </div>
            </div>
          </template>
        </div>
      </header>

  </template>
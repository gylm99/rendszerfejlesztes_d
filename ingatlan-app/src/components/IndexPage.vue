
<script>
import ItemShow from './ItemShow.vue';


export default {
  name: "IndexPage",
  components: {
    ItemShow // Register the child component
  }
};
</script>

<template>

   <body class="bg-gray-100 h-screen">
        <!-- Header -->
        <header class="bg-white shadow py-4 px-6 flex ItemShows-center justify-between">
            <!-- Search Bar -->
            <div class="flex ItemShows-center w-full max-w-md">
                <input type="text" placeholder="Search..." class="w-full px-4 py-2 border rounded-md border-green-300 focus:outline-none focus:border-green-800">
                <button class="bg-green-600 text-white px-4 py-2 rounded-md hover:bg-green-900 focus:outline-none mx-5">
                    Filter
                </button>
            </div>
     
            <router-link to="/">
                <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
            </router-link> 
            
            <!-- Sign In / Register Buttons -->
                <div class="flex space-x-4">
                    <router-link to="/signin">
                <button @click="isSignInActive = true" class="px-4 py-2 bg-gray-300 text-gray-800 rounded-md hover:bg-gray-400 hover:text-white focus:outline-none">
                    Sign In
                </button>
            </router-link> 
            <router-link to="/signup">
                <button class="px-4 py-2 bg-green-600 text-white rounded-md hover:bg-green-900 focus:outline-none">
                    Register
                </button>
            </router-link>
            </div>
        </header>

        <!-- Content Grid -->
        <main class="p-6">
            <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-6 gap-6">
                <!-- Card 1 -->
                <ItemShow />
                <!-- Card 2 -->
                <ItemShow />
                <!-- Card 3 -->
                <ItemShow />
                <!-- Card 4 -->
                <ItemShow />
                <!-- Card 4 -->
                <ItemShow />
                <!-- Card 5 -->
                <ItemShow />
                <!-- Card 6 -->
                <ItemShow />
                <!-- Card 7 -->
                <ItemShow />
                <!-- Card 8 -->
                <ItemShow />
                <!-- Card 9 -->
                <ItemShow />
                <!-- Card 10 -->
                <ItemShow />
                <!-- Card 11 -->
                <ItemShow />
                <!-- Card 12 -->
                <ItemShow />
                <!-- Card 13 -->
                <ItemShow />
                <!-- Card 14 -->
                <ItemShow />
                <!-- Card 15 -->
                <ItemShow />
                <!-- Card 16 -->
                <ItemShow />
                <!-- Card 17 -->
                <ItemShow />
                
            </div>
        </main>
        <main class="p-6">
        <div id="ItemShow-container" class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6 mb-6"></div>
        
        <!-- Pagination Controls -->
        <div class="flex justify-center space-x-2">
            <button id="prev" class="pagination-btn px-3 py-1 border rounded" @click="changePage">Previous</button>
            <span id="page-indicator" class="font-semibold text-gray-700">Page 1</span>
            <button id="next" class="pagination-btn px-3 py-1 border rounded" @click="changePage">Next</button>
        </div>
    </main>
</body>
<router-view/>
</template>


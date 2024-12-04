
<script>
import ItemShow from "./ItemShow.vue";
import NavBar from "./NavBar.vue";


export default {
  name: "IndexPage",
  components: {
    ItemShow,
    NavBar
  },
};
</script>

<template>
  <NavBar />
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
        
        <div class="flex justify-center space-x-2">
            <button id="prev" class="pagination-btn px-3 py-1 border rounded" @click="changePage">Previous</button>
            <span id="page-indicator" class="font-semibold text-gray-700">Page 1</span>
            <button id="next" class="pagination-btn px-3 py-1 border rounded" @click="changePage">Next</button>
        </div>
    </main>
<router-view/>
</template>


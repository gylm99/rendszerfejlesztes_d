<template>
   <body class="bg-gray-100">
        <!-- Header -->
        <header class="bg-white shadow py-4 px-6 flex items-center justify-between">
            <!-- Search Bar -->
            <div class="flex items-center w-full max-w-md">
                <input type="text" placeholder="Search..." class="w-full px-4 py-2 border rounded-l-md border-gray-300 focus:outline-none focus:border-indigo-500">
                <button class="bg-indigo-500 text-white px-4 py-2 rounded-r-md hover:bg-indigo-600 focus:outline-none">
                    Filter
                </button>
            </div>
            <div>
                <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
            </div>
            <!-- Sign In / Register Buttons -->
            <div class="flex space-x-4">
                <button class="px-4 py-2 bg-gray-300 text-gray-800 rounded-md hover:bg-gray-400 focus:outline-none">
                    Sign In
                </button>
                <button class="px-4 py-2 bg-indigo-500 text-white rounded-md hover:bg-indigo-600 focus:outline-none">
                    Register
                </button>
            </div>
        </header>

        <!-- Content Grid -->
        <main class="p-6">
            <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6">
                <!-- Card -->
                <div class="bg-white shadow rounded-lg overflow-hidden">
                    <img src="https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    <div class="p-4">
                        <h3 class="text-lg font-semibold mb-2">Product Title</h3>
                        <p class="text-gray-600">$99.99</p>
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded">New Arrival</span>
                    </div>
                </div>

                <!-- Repeat Card for More Products -->
                <div class="bg-white shadow rounded-lg overflow-hidden">
                    <img src="https://images.pexels.com/photos/186077/pexels-photo-186077.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    <div class="p-4">
                        <h3 class="text-lg font-semibold mb-2">Product Title</h3>
                        <p class="text-gray-600">$99.99</p>
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded">New Arrival</span>
                    </div>
                </div>
                <div class="bg-white shadow rounded-lg overflow-hidden">
                    <img src="https://images.pexels.com/photos/186077/pexels-photo-186077.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    <div class="p-4">
                        <h3 class="text-lg font-semibold mb-2">Product Title</h3>
                        <p class="text-gray-600">$99.99</p>
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded">New Arrival</span>
                    </div>
                </div>
                <div class="bg-white shadow rounded-lg overflow-hidden">
                    <img src="https://images.pexels.com/photos/186077/pexels-photo-186077.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    <div class="p-4">
                        <h3 class="text-lg font-semibold mb-2">Product Title</h3>
                        <p class="text-gray-600">$99.99</p>
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded">New Arrival</span>
                    </div>
                </div>
                <div class="bg-white shadow rounded-lg overflow-hidden">
                    <img src="https://images.pexels.com/photos/186077/pexels-photo-186077.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    <div class="p-4">
                        <h3 class="text-lg font-semibold mb-2">Product Title</h3>
                        <p class="text-gray-600">$99.99</p>
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded">New Arrival</span>
                    </div>
                </div>
            </div>
        </main>
        <main class="p-6">
        <div id="item-container" class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6 mb-6"></div>
        
        <!-- Pagination Controls -->
        <div class="flex justify-center space-x-2">
            <button id="prev" class="pagination-btn px-3 py-1 border rounded">Previous</button>
            <span id="page-indicator" class="font-semibold text-gray-700">Page 1</span>
            <button id="next" class="pagination-btn px-3 py-1 border rounded">Next</button>
        </div>
    </main>
</body>
</template>

<script>
export default {
    name: 'IndexPage'
}
// new Pagination({
//             el: "#app",
//             data() {
//                 return {
//                     items: Array.from({ length: 100 }, (_, i) => ({
//                         title: `Product ${i + 1}`,
//                         price: `$${(Math.random() * 100).toFixed(2)}`,
//                         label: "New Arrival",
//                         imageUrl: "https://via.placeholder.com/400"
//                     })),
//                     currentPage: 1,
//                     itemsPerPage: 1 // Placeholder value, will update on mount
//                 };
//             },
//             computed: {
//                 paginatedItems() {
//                     const start = (this.currentPage - 1) * this.itemsPerPage;
//                     const end = start + this.itemsPerPage;
//                     return this.items.slice(start, end);
//                 }
//             },
//             methods: {
//                 calculateItemsPerPage() {
//                     const width = window.innerWidth;
//                     if (width >= 1024) return 16;
//                     if (width >= 768) return 9;
//                     if (width >= 640) return 4;
//                     return 1;
//                 },
//                 changePage(direction) {
//                     const totalPages = Math.ceil(this.items.length / this.itemsPerPage);
//                     if (direction === 'next' && this.currentPage < totalPages) {
//                         this.currentPage++;
//                     } else if (direction === 'prev' && this.currentPage > 1) {
//                         this.currentPage--;
//                     }
//                 },
//                 handleResize() {
//                     const newItemsPerPage = this.calculateItemsPerPage();
//                     if (newItemsPerPage !== this.itemsPerPage) {
//                         this.itemsPerPage = newItemsPerPage;
//                         this.currentPage = 1; // Reset to first page
//                     }
//                 }
//             },
//             mounted() {
//                 // Set items per page based on initial window size
//                 this.itemsPerPage = this.calculateItemsPerPage();
//                 // Add resize listener to recalculate items per page on screen resize
//                 window.addEventListener("resize", this.handleResize);
//             },
//             beforeDestroy() {
//                 window.removeEventListener("resize", this.handleResize);
//             }
//         });
</script>

<template>

   <body class="bg-gray-100 h-screen">
        <!-- Header -->
        <header class="bg-white shadow py-4 px-6 flex items-center justify-between">
            <!-- Search Bar -->
            <div class="flex items-center w-full max-w-md">
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
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 2 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/3288100/pexels-photo-3288100.png?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">110k Ft/month</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Kereszttöltés utca 52</h3>
                        <p class="text-gray-600">41 m<sup>2</sup></p>
                        <p class="text-gray-600">5 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 3 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/323780/pexels-photo-323780.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">46,60 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">80 m<sup>2</sup></p>
                        <p class="text-gray-600">- m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 4 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/1396132/pexels-photo-1396132.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 4 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 5 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/3288102/pexels-photo-3288102.png?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 6 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/280229/pexels-photo-280229.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">120k Ft/month</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 7 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/3623770/pexels-photo-3623770.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">42,30 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 8 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/186077/pexels-photo-186077.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 9 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/3209045/pexels-photo-3209045.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">150k Ft/month</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <p>Szeged, Kossuth Lajos sugárút 20</p>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 10 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/6283973/pexels-photo-6283973.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 11 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/1571470/pexels-photo-1571470.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 12 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/221024/pexels-photo-221024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 13 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/277667/pexels-photo-277667.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 14 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/259593/pexels-photo-259593.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 15 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Rent</span>
                        <img src="https://images.pexels.com/photos/280232/pexels-photo-280232.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 16 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/209315/pexels-photo-209315.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                <!-- Card 17 -->
                <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/1438832/pexels-photo-1438832.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                    <div class="grid grid-cols-3 px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
                
            </div>
        </main>
        <main class="p-6">
        <div id="item-container" class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6 mb-6"></div>
        
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


<script>



</script>
